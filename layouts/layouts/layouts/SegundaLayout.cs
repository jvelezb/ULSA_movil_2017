using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace layouts
{
    class SegundaLayout : ContentPage
    {
        public SegundaLayout()
        {
            RelativeLayout layoutRelativo = new RelativeLayout();

            Label etiqueta1 = new Label
            {
                Text = "izquierda"
            };
            layoutRelativo.Children.Add(etiqueta1, Constraint.Constant(0), Constraint.Constant(0));
            Label etiqueta2 = new Label
            {
                Text = "etiqueta 2"
            };
            layoutRelativo.Children.Add(etiqueta2, Constraint.Constant(0),
                    Constraint.RelativeToView(etiqueta1, (parent, sibling) => {
                        return sibling.Y + sibling.Height;
                    })
                );
            
        }

    }
}
