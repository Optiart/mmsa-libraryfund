using System;
using System.Windows.Forms;

namespace CityLibraryFund.Helpers
{
    public static class MessageBoxHelper
    {
        public static Func<DialogResult> EmptyCityListMessageBox = () =>
            MessageBox.Show($"У базі не знайдено жодного міста", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);

        public static Func<string, DialogResult> InitErrorMessageBox = (string message) =>
            MessageBox.Show($"Вибачте, сталася помилка ініціалізації: {message}. Спробуйте перезапустити програму", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
