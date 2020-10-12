﻿using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp.Models;

namespace ConsoleApp
{
	public class DatabaseAccess
	{
		public String GetSnippetsTitles()
		{
			String titles = "";

			var context = new snippetsContext();
			List<Snippets> snippets = context.Snippets.Select(x => x).OrderBy(x => x.Title).ToList();

			foreach (var snippet in snippets)
			{
				titles += snippet.Title + "\r\n";
			}

			return titles;
		}
	}
}
