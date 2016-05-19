using System;

namespace PasswordKata.Tests
{
	public sealed class PasswordVerifierBuilder : IBuilder
	{
		private readonly PasswordVerifier _passwordVerifier;
		private string _password;

		public PasswordVerifierBuilder()
		{
		}

		public PasswordVerifier Build() => new PasswordVerifier(_password);

		public PasswordVerifier WithPassword(string password) => this.With(ref _password, password);

		public static implicit operator PasswordVerifier(PasswordVerifierBuilder builder) => builder.Build();
	}
}

