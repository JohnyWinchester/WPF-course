using AndreyMatveewDZ01.Model.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Controls;

namespace UnitTests
{
    [TestClass]
    public class ValidationTests
    {
        EmailValidation emailValidation;
        PasswordValidation passwordValidation;
        LoginValidation loginValidation;

        #region Email Validation Tests
        [TestMethod]
        public void EmailValidTrue()
        {
            emailValidation = new EmailValidation();

            List<string> emailCases = new List<string>()
            {
                "Andreymak007@gmail.com",
                "ciclop@yandex.ru",
                "Abobus@mail.ru"
            };

            foreach (var el in emailCases)
                Assert.IsTrue(emailValidation.Validate(el, new CultureInfo("en-us", false)).IsValid);
        }
        [TestMethod]
        public void EmailValidFalse()
        {
            emailValidation = new EmailValidation();

            List<string> emailCases = new List<string>()
            {
                "Andreyxomak",
                "@yandex.ru",
                "Abobus@mail"
            };

            foreach (var el in emailCases)
                Assert.IsFalse(emailValidation.Validate(el, new CultureInfo("en-us", false)).IsValid);
        }
        #endregion

        #region Password Validation Tests
        [TestMethod]
        public void PasswordValidTrue()
        {
            passwordValidation = new PasswordValidation();
            List<string> passwordCases = new List<string>()
            {
                "ANTON.377.h",
                "bo.br.ik.8",
                "WDadad/666"
            };

            foreach (var el in passwordCases)
                Assert.IsTrue(passwordValidation.Validate(el, new CultureInfo("en-us", false)).IsValid);
        }

        [TestMethod]
        public void PasswordValidFalse()
        {
            passwordValidation = new PasswordValidation();

            List<string> passwordCases = new List<string>()
            {
                "Jk,orly,k7wwwwwwwwwww",
                "ANTON",
                "ANTON377"
            };

            foreach (var el in passwordCases)
                Assert.IsFalse(passwordValidation.Validate(el, new CultureInfo("en-us", false)).IsValid);
        }
        #endregion

        #region Login Validation Tests
        [TestMethod]
        public void LoginValidTrue()
        {
            loginValidation = new LoginValidation();

            List<string> loginCases = new List<string>()
            {
                "ANTON377",
                "PinkaKolad",
                "PinkaKolada333"
            };

            foreach (var el in loginCases)
                Assert.IsTrue(loginValidation.Validate(el, new CultureInfo("en-us", false)).IsValid);

        }

        [TestMethod]
        public void LoginValidFalse()
        {
            loginValidation = new LoginValidation();

            List<string> loginCases = new List<string>()
            {
                "J",
                "ANTON000000000000000222",
                "ANTON/////"
            };

            foreach (var el in loginCases)
                Assert.IsFalse(loginValidation.Validate(el, new CultureInfo("en-us", false)).IsValid);

        }
        #endregion
    }
}
