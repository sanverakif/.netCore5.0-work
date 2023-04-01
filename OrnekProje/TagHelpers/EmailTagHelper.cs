using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekProje.TagHelpers
{
    [HtmlTargetElement("akif")]
    public class EmailTagHelper : TagHelper
    {
        public string Mail { get; set; }
        public string Display { get; set; }
        //context: tag helperin özelliklerini getirir. output:çıktı olarak ne vericeği. process: ilgili tag helperin işleminin yapıldığı fonksiyondur
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.Add("href", $"mailto:{Mail}");
            output.Content.Append(Display);
            base.Process(context, output);
        }
    }
    public class AkifEmre : TagHelper { }
}
