using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MTG_Card_Collection_App.TagHelpers
{
    public class ButtonTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (context.AllAttributes.ContainsName("class"))
            {

            } else
            {
                output.Attributes.SetAttribute("class", "btn btn-primary");
            }
            
        }
    }
}
