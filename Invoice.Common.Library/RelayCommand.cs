using System;
using System.Diagnostics;
using System.Windows.Input;

namespace Invoice.Common.Library
{

    public class RelayCommand : ICommand
    {
        #region Variables
        private readonly Action<Object> m_Execute = null;
        private readonly Predicate<Object> m_CanExecute = null;
        #endregion

        #region Constructor
        public RelayCommand(Action<Object> execute)
            : this(execute, null)
        {
        }
        public RelayCommand(Action<Object> execute, Predicate<Object> canexecute)
        {
            if (execute == null)
                throw new ArgumentNullException();
            m_Execute = execute;
            m_CanExecute = canexecute;
        }
        #endregion

        #region Methods
        #endregion

        #region ICommand Members
        [DebuggerStepThrough]
        public bool CanExecute(Object m_Parameter)
        {
            return m_CanExecute == null ? true : m_CanExecute(m_Parameter);
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public void Execute(Object m_Parameter)
        {
            m_Execute(m_Parameter);
        }
        #endregion
    }
}
