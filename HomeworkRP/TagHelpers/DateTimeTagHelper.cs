using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourceStack.TagHelpers
{
    [HtmlTargetElement("datetime", Attributes = "asp-showicon,asp-only")]
    ///必须继承自TagHelper
    public class PagerTagHelper : TagHelper
    {
        //context: 能够获取attributes的信息
        //output：输出的原生html标签
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "small";   //原生标签名
            if (context.AllAttributes["asp-showicon"].Value.ToString() == "true")
            {
                output.PreContent.AppendHtml("<span class=\"fa fa-calendar \"></span>");
            }
            if (context.AllAttributes["asp-only"].Value.ToString() == "date")
            {
                output.Content.AppendHtml(DateTime.Now.Date.ToString("yyyy年MM月dd日"));
            }

            base.Process(context, output);
        }
    }
}
