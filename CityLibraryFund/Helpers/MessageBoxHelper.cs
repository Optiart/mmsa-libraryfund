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

        public static Func<string, DialogResult> EnteredInvalidData = (string message) =>
            MessageBox.Show($"Введено неправильні дані: {message}. ", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        public static Func<string, DialogResult> GeneralErrorMessageBox = (string message) =>
            MessageBox.Show($"Вибачте, сталася помилка: {message}. Спробуйте ще раз", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        public static Func<string, DialogResult> DeleteConfirmationMessageBox = (string message) =>
            MessageBox.Show($"Видалити {message}?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        public static Func<DialogResult> EntityAlreadyDeletedMessageBox = () =>
            MessageBox.Show($"Обраний об'єкт вже видалено. Оновіть, будь ласка, список", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);

        public static Func<DialogResult> EntityNotFoundMessageBox = () =>
            MessageBox.Show($"Обраний об'єкт не знайдено. Оновіть, будь ласка, список", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
