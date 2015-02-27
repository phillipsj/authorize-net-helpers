using System;
using System.Web.Mvc;

namespace AuthorizeNet.Helpers
{
    public static class FormExtensions
    {
        private class DirectPostForm : IDisposable
        {
            private readonly HtmlHelper _helper;

            public DirectPostForm(HtmlHelper helper, string apiLogin, string transactionKey, decimal amount,
                string returnUrl, bool isTest)
            {
                _helper = helper;
                _helper.ViewContext.Writer.Write(DPMFormGenerator.OpenForm(apiLogin, transactionKey, amount, returnUrl,
                    isTest));
            }

            public void Dispose()
            {
                _helper.ViewContext.Writer.Write(DPMFormGenerator.EndForm());
            }
        }

        public static IDisposable BeginDirectPostForm(this HtmlHelper helper, string apiLogin, string transactionKey,
            decimal amount,
            string returnUrl, bool isTest)
        {
            return new DirectPostForm(helper, apiLogin, transactionKey, amount, returnUrl, isTest);
        }
    }
}
