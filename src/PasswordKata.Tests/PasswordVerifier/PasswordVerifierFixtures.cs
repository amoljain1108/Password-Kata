using System;
using Xunit;

namespace PasswordKata.Tests
{
	public class PasswordVerifierFixtures
	{
		[Theory]
		[InlineData(null, true)]
		public void Password_Should_Be_Larger_Than_8_Chars(string password, bool expected)
		{
			// var sut = new ...()...("password")...();
			// sut.Verify().Should.Be(expected);
		}
	}
}
