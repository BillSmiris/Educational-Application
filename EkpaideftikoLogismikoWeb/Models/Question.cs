using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EkpaideftikoLogismikoWeb.Models
{
    public class Question
    {
		private string text;
		private List<Answer> answers;

		public Question(string text, List<Answer> answers)
		{
			this.text = text;
			this.answers = answers;
		}

		public string Text
		{
			get { return text; }
		}

		public List<Answer> Answers
		{
			get { return answers; }
		}
	}
}