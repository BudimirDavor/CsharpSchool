<%@ WebService Language="C#" Class="AlphabetString" %>

using System;
using System.Web.Services;

[WebService(Name="AlphabetStringWebService", Description="Dodatne metoda za klasu string")]
class AlphabetString
{
	[WebMethod(Description="Vraæa prvi znak po abecedi iz prosljeðenog stringa")]
	public int FirstByAlphabet(string s)
	{
		char c = 'z';
		for(int i=0;i<s.Length;i++)
		{
			s = s.ToLower();
			if(s[i] < c  &&  s[i] >= 97  &&  s[i] <= 122)
				c = s[i];
		}
		return (int)c;
	}

	[WebMethod(Description="Vraæa zadnji znak po abecedi iz prosljeðenog stringa")]
	public int LastByAlphabet(string s)
	{
		char c = 'a';
		for(int i=0;i<s.Length;i++)
		{
			s = s.ToLower();
			if(s[i] > c  &&  s[i] >= 97  &&  s[i] <= 122)
				c = s[i];
		}
		return (int)c;
	}
}
