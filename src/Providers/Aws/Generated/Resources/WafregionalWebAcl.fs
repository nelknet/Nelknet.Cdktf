namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WafregionalWebAclState<'DefaultAction, 'MetricName, 'Name> = { assignments: ResizeArray<aws.WafregionalWebAcl.WafregionalWebAclConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_web_acl">aws_wafregional_web_acl</a>.
    /// </summary>
    type WafregionalWebAclBuilder(logicalId: string) =
        member _.Yield(_: unit) : WafregionalWebAclState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WafregionalWebAclState<Missing, Missing, Missing>)

        member _.Zero(()) : WafregionalWebAclState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WafregionalWebAclState<Missing, Missing, Missing>)

        /// <summary>
        /// default_action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_web_acl#default_action-1">WafregionalWebAcl#default_action</a>
        /// </summary>
        [<CustomOperation "default_action">]
        member _.DefaultAction(state: WafregionalWebAclState<Missing, 'MetricName, 'Name>, value: aws.WafregionalWebAcl.WafregionalWebAclDefaultAction) : WafregionalWebAclState<Present, 'MetricName, 'Name> =
            state.assignments.Add(fun config -> config.DefaultAction <- value)
            ({ assignments = state.assignments } : WafregionalWebAclState<Present, 'MetricName, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_web_acl#metric_name-1">WafregionalWebAcl#metric_name</a>.
        /// </summary>
        [<CustomOperation "metric_name">]
        member _.MetricName(state: WafregionalWebAclState<'DefaultAction, Missing, 'Name>, value: string) : WafregionalWebAclState<'DefaultAction, Present, 'Name> =
            state.assignments.Add(fun config -> config.MetricName <- value)
            ({ assignments = state.assignments } : WafregionalWebAclState<'DefaultAction, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_web_acl#name-1">WafregionalWebAcl#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WafregionalWebAclState<'DefaultAction, 'MetricName, Missing>, value: string) : WafregionalWebAclState<'DefaultAction, 'MetricName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WafregionalWebAclState<'DefaultAction, 'MetricName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_web_acl#id-1">WafregionalWebAcl#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WafregionalWebAclState<'DefaultAction, 'MetricName, 'Name>, value: string) : WafregionalWebAclState<'DefaultAction, 'MetricName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WafregionalWebAclState<'DefaultAction, 'MetricName, 'Name>

        /// <summary>
        /// logging_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_web_acl#logging_configuration-1">WafregionalWebAcl#logging_configuration</a>
        /// </summary>
        [<CustomOperation "logging_configuration">]
        member _.LoggingConfiguration(state: WafregionalWebAclState<'DefaultAction, 'MetricName, 'Name>, value: aws.WafregionalWebAcl.WafregionalWebAclLoggingConfiguration) : WafregionalWebAclState<'DefaultAction, 'MetricName, 'Name> =
            state.assignments.Add(fun config -> config.LoggingConfiguration <- value)
            state : WafregionalWebAclState<'DefaultAction, 'MetricName, 'Name>

        /// <summary>
        /// rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_web_acl#rule-1">WafregionalWebAcl#rule</a> Accepts: aws.IResolvable | aws.WafregionalWebAcl.WafregionalWebAclRule[]
        /// </summary>
        [<CustomOperation "rule">]
        member _.Rule(state: WafregionalWebAclState<'DefaultAction, 'MetricName, 'Name>, value: HashiCorp.Cdktf.IResolvable) : WafregionalWebAclState<'DefaultAction, 'MetricName, 'Name> =
            state.assignments.Add(fun config -> config.Rule <- value)
            state : WafregionalWebAclState<'DefaultAction, 'MetricName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_web_acl#tags-1">WafregionalWebAcl#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: WafregionalWebAclState<'DefaultAction, 'MetricName, 'Name>, value: seq<string * string>) : WafregionalWebAclState<'DefaultAction, 'MetricName, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : WafregionalWebAclState<'DefaultAction, 'MetricName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafregional_web_acl#tags_all-1">WafregionalWebAcl#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: WafregionalWebAclState<'DefaultAction, 'MetricName, 'Name>, value: seq<string * string>) : WafregionalWebAclState<'DefaultAction, 'MetricName, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : WafregionalWebAclState<'DefaultAction, 'MetricName, 'Name>

        member _.Run(state: WafregionalWebAclState<Present, Present, Present>) : aws.WafregionalWebAcl.WafregionalWebAcl =
            let config = aws.WafregionalWebAcl.WafregionalWebAclConfig()
            for setter in state.assignments do
                setter config
            aws.WafregionalWebAcl.WafregionalWebAcl(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafregionalWebAcl: missing required arguments. Must call: default_action, metric_name, name.", 9999, IsError = true)>]
        member _.Run(_: WafregionalWebAclState<_, _, _>) : aws.WafregionalWebAcl.WafregionalWebAcl =
            Unchecked.defaultof<aws.WafregionalWebAcl.WafregionalWebAcl>
