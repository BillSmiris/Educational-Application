using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace EkpaideftikoLogismiko
{
    /// <summary>
    /// Interaction logic for Quiz.xaml
    /// </summary>
    public partial class Quiz : UserControl
    {
        private static int questionTime = 30;
        private string unit;
        private StreamReader sr;
        private DispatcherTimer timer;
        private int time;
        private bool[] answers = new bool[4];
        private double correctQuestions = 0;
        private double totalQuestions = 0;
        private int currentQuestions = 0;

        public Quiz(string unit)
        {   
            InitializeComponent();
            this.DataContext = this;
            this.unit = unit;
            StreamResourceInfo info = Application.GetResourceStream(new Uri("/Resources/Data/quizes/" + unit + ".txt", UriKind.Relative));
            sr = new StreamReader(info.Stream);
            totalQuestions = double.Parse(sr.ReadLine());
            time = questionTime;
            questionTimer.Text = TimeString();
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
            RenderQuestion();
        }

        private bool RenderQuestion()
        {
            string q = sr.ReadLine();
            if (string.IsNullOrEmpty(q))
            {
                timer.Stop();
                grade.Text = "Βαθμολογία: " + Math.Floor(correctQuestions / totalQuestions * 100) + "%";
                questionPanel.Visibility = Visibility.Collapsed;
                endPanel.Visibility = Visibility.Visible;
                questionTimer.Visibility = Visibility.Hidden;
                title.Text = "Tέλος";
                return false;
            }
            currentQuestions++;
            title.Text = "Ερώτηση " + currentQuestions + "/" + totalQuestions;
            question.Text = q;
            string[] a;
            a = sr.ReadLine().Split("|");
            answer1.Content = a[0];
            answers[0] = bool.Parse(a[1]);
            a = sr.ReadLine().Split("|");
            answer2.Content = a[0];
            answers[1] = bool.Parse(a[1]);
            a = sr.ReadLine().Split("|");
            answer3.Content = a[0];
            answers[2] = bool.Parse(a[1]);
            a = sr.ReadLine().Split("|");
            answer4.Content = a[0];
            answers[3] = bool.Parse(a[1]);
            ResetControls();
            ResetTimer();
            return true;
        }

        public void timer_Tick(object sender, EventArgs e)
        {
            time--;
            questionTimer.Text = TimeString();
            if (time == 0)
            {
                RenderQuestion();
            }
        }

        public bool CheckAnswer()
        {
            if (answer1.IsChecked == true)
            {
                return answers[0];
            }
            else if(answer2.IsChecked == true)
            {
                return answers[1];
            }
            else if(answer3.IsChecked == true)
            {
                return answers[2];
            }
            else if(answer4.IsChecked == true)
            {
                return answers[3];
            }
            return false;
        }

        private void answerButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            if (CheckAnswer()) {
                correctQuestions++;
            }

            if (RenderQuestion())
            {
                ResetTimer();
                timer.Start();
            }
        }

        private void ResetControls()
        {
            answer1.IsChecked = false;
            answer2.IsChecked = false;
            answer3.IsChecked = false;
            answer4.IsChecked = false;
            answerButton.IsEnabled = false;
        }

        private void answer_Checked(object sender, RoutedEventArgs e)
        {
            if (answer1.IsChecked == true || answer2.IsChecked == true || answer3.IsChecked == true || answer4.IsChecked == true)
            {
                answerButton.IsEnabled = true;
            }
            else
            {
                answerButton.IsEnabled = false;
            }
        }

        private string TimeString()
        {
            if (time < 10)
            {
                return "00:0" + time;
            }
            else if (time < 60)
            {
                return "00:" + time;
            }
            else
            {
                return "01:00";
            }
        }

        private void ResetTimer()
        {
            time = questionTime;
            questionTimer.Text = TimeString();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            (VisualTreeHelper.GetParent(VisualTreeHelper.GetParent(this)) as ContentControl).Content = new QuizMenu();
        }

        private void restartButton_Click(object sender, RoutedEventArgs e)
        {
            (VisualTreeHelper.GetParent(VisualTreeHelper.GetParent(this)) as ContentControl).Content = new Quiz(unit);
        }
    }
}
