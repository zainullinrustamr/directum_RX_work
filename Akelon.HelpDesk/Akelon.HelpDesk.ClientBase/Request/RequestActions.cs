using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Akelon.HelpDesk.Request;

namespace Akelon.HelpDesk.Client
{
  partial class RequestActions
  {
    public virtual void CreateAddendumRequest(Sungero.Domain.Client.ExecuteActionArgs e)
    {
      Functions.Request.Remote.CreateAddendumRequest(_obj).Show();
    }

    public virtual bool CanCreateAddendumRequest(Sungero.Domain.Client.CanExecuteActionArgs e)
    {
      return true;
    }

    public virtual void OpenRequest(Sungero.Domain.Client.ExecuteActionArgs e)
    {
      _obj.LifeCycle = HelpDesk.Request.LifeCycle.InWork;
      _obj.State.IsEnabled = true;
      _obj.ClosedDate = null;
      
    }

    public virtual bool CanOpenRequest(Sungero.Domain.Client.CanExecuteActionArgs e)
    {
      return _obj.LifeCycle == LifeCycle.Closed && !_obj.State.IsChanged;
      
      //if (_obj.LifeCycle.Value == HelpDesk.Request.LifeCycle.Closed)
      //{
      //  return true;
      //}
      //else
      // {
      // return false;
      //}
    }

  }


}