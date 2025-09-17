using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Akelon.HelpDesk.ExternalRequest;

namespace Akelon.HelpDesk
{
  partial class ExternalRequestEmployeesCollectionSharedCollectionHandlers
  {

    public override void EmployeesCollectionAdded(Sungero.Domain.Shared.CollectionPropertyAddedEventArgs e)
    {
      
      base.EmployeesCollectionAdded(e);
      _added.Employee = Sungero.Company.Employees.Current; 
      
    }
  }
}