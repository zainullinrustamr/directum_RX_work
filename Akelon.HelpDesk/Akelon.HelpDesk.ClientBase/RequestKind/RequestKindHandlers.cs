using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Akelon.HelpDesk.RequestKind;

namespace Akelon.HelpDesk
{
  partial class RequestKindClientHandlers
  {

    public override void Showing(Sungero.Presentation.FormShowingEventArgs e)
    {
      //_obj.State.Properties.Name.IsVisible = false;
      var doc = Sungero.Docflow.SimpleDocuments.Get(2);
      var hyperlink = Hyperlinks.Get(doc); 
      e.Instruction = "Проверьте документ "+ hyperlink;
      
      //_obj.State.IsEnabled = false;
      //_obj.State.Properties.Name.IsEnabled = false;
    }

    public override void Refresh(Sungero.Presentation.FormRefreshEventArgs e)
    {
      _obj.State.Properties.Name.HighlightColor = Colors.Common.Green;
      _obj.State.Properties.Status.HighlightColor = Colors.Common.Yellow;
      // Показать всплывающее сообщение с информацией о том, что дубли не найдены.
      //Dialogs.NotifyMessage("Дубли не найдены");
      //if (_obj.State.IsInserted)
      //{
      //  Dialogs.NotifyMessage("Заполните обязательные поля");
      //}
    }

  }
}