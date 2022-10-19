using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SOFOIAN_EF_HT1.MVVM.Core
{
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// CallerMemberNameAttribute: Позволяет получить имя метода, который вызвал ваш код.
        /// </summary>
        /// <param name="propoertyName">Имя свойства</param>
        private void OnPropertyChanged([CallerMemberName] string propoertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propoertyName));
        }
    }
}
