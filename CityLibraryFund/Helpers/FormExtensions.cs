using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityLibraryFund.Helpers
{
    public static class FormExtensions
    {
        public static async Task WrapWithWaitingCursor(this Form form, Func<Task> asyncOperation)
        {
            if (form == null)
            {
                throw new ArgumentNullException(nameof(form));
            }

            var currentCursor = form.Cursor;
            form.Cursor = Cursors.WaitCursor;
            try
            {
                await asyncOperation();
            }
            finally
            {
                form.Cursor = currentCursor;
            }
        }

        public static async Task<T> WrapWithWaitingCursor<T>(this Form form, Func<Task<T>> asyncOperation)
        {
            if (form == null)
            {
                throw new ArgumentNullException(nameof(form));
            }

            var currentCursor = form.Cursor;
            form.Cursor = Cursors.WaitCursor;
            try
            {
                return await asyncOperation();
            }
            finally
            {
                form.Cursor = currentCursor;
            }
        }
    }
}
