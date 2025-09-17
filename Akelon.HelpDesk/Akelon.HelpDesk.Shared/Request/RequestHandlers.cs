using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Akelon.HelpDesk.Request;

namespace Akelon.HelpDesk
{
  partial class RequestEmployeesCollectionSharedHandlers
  {

    public virtual void EmployeesCollectionNumberHoursChanged(Sungero.Domain.Shared.DoublePropertyChangedEventArgs e)
    { 
      _obj.Request.AmountHours = _obj.Request.EmployeesCollection.Sum(l => l.NumberHours);
      
    }
  }

  partial class RequestSharedHandlers
  {

  }
}