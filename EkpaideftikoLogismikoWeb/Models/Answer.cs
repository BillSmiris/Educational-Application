using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EkpaideftikoLogismikoWeb.Models
{
    public class Answer
    {
		private string text;
		private bool value;

		public Answer(string text, bool value)
		{
			this.text = text;
			this.value = value;
		}

		public string Text
		{
			get { return text; }
		}
		public bool Value
		{
			get { return value; }
		}

	}
}