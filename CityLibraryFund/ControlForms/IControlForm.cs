using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityLibraryFund.ControlForms
{
    public interface IControlForm
    {
        DialogResult ShowDialog();

        Task LoadEntity(uint id);

        Task<bool> DeleteEntiy(uint id);
    }
}
