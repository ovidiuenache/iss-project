using App.Entity;
using System.Windows.Forms;

namespace App.Controller
{
    /// <summary>
    /// 
    /// Phase one controller interface
    /// Author : Catalin Radoiu
    /// Author : Ioan Ovidiu Enache
    /// 
    /// </summary>
    public interface IPhaseOneController
    {
        BindingSource ProposalsAuthoredByUser(int userId);

        void saveChanges();
    }
}