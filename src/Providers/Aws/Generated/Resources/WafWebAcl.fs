namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WafWebAclState<'DefaultAction, 'MetricName, 'Name> = { assignments: ResizeArray<aws.WafWebAcl.WafWebAclConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_web_acl">aws_waf_web_acl</a>.
    /// </summary>
    type WafWebAclBuilder(logicalId: string) =
        member _.Yield(_: unit) : WafWebAclState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WafWebAclState<Missing, Missing, Missing>)

        member _.Zero(()) : WafWebAclState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WafWebAclState<Missing, Missing, Missing>)

        /// <summary>
        /// default_action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_web_acl#default_action-1">WafWebAcl#default_action</a>
        /// </summary>
        [<CustomOperation "default_action">]
        member _.DefaultAction(state: WafWebAclState<Missing, 'MetricName, 'Name>, value: aws.WafWebAcl.WafWebAclDefaultAction) : WafWebAclState<Present, 'MetricName, 'Name> =
            state.assignments.Add(fun config -> config.DefaultAction <- value)
            ({ assignments = state.assignments } : WafWebAclState<Present, 'MetricName, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_web_acl#metric_name-1">WafWebAcl#metric_name</a>.
        /// </summary>
        [<CustomOperation "metric_name">]
        member _.MetricName(state: WafWebAclState<'DefaultAction, Missing, 'Name>, value: string) : WafWebAclState<'DefaultAction, Present, 'Name> =
            state.assignments.Add(fun config -> config.MetricName <- value)
            ({ assignments = state.assignments } : WafWebAclState<'DefaultAction, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_web_acl#name-1">WafWebAcl#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: WafWebAclState<'DefaultAction, 'MetricName, Missing>, value: string) : WafWebAclState<'DefaultAction, 'MetricName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : WafWebAclState<'DefaultAction, 'MetricName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_web_acl#id-1">WafWebAcl#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: WafWebAclState<'DefaultAction, 'MetricName, 'Name>, value: string) : WafWebAclState<'DefaultAction, 'MetricName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : WafWebAclState<'DefaultAction, 'MetricName, 'Name>

        /// <summary>
        /// logging_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_web_acl#logging_configuration-1">WafWebAcl#logging_configuration</a>
        /// </summary>
        [<CustomOperation "logging_configuration">]
        member _.LoggingConfiguration(state: WafWebAclState<'DefaultAction, 'MetricName, 'Name>, value: aws.WafWebAcl.WafWebAclLoggingConfiguration) : WafWebAclState<'DefaultAction, 'MetricName, 'Name> =
            state.assignments.Add(fun config -> config.LoggingConfiguration <- value)
            state : WafWebAclState<'DefaultAction, 'MetricName, 'Name>

        /// <summary>
        /// rules block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_web_acl#rules-1">WafWebAcl#rules</a> Accepts: aws.IResolvable | aws.WafWebAcl.WafWebAclRules[]
        /// </summary>
        [<CustomOperation "rules">]
        member _.Rules(state: WafWebAclState<'DefaultAction, 'MetricName, 'Name>, value: HashiCorp.Cdktf.IResolvable) : WafWebAclState<'DefaultAction, 'MetricName, 'Name> =
            state.assignments.Add(fun config -> config.Rules <- value)
            state : WafWebAclState<'DefaultAction, 'MetricName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_web_acl#tags-1">WafWebAcl#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: WafWebAclState<'DefaultAction, 'MetricName, 'Name>, value: seq<string * string>) : WafWebAclState<'DefaultAction, 'MetricName, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : WafWebAclState<'DefaultAction, 'MetricName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/waf_web_acl#tags_all-1">WafWebAcl#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: WafWebAclState<'DefaultAction, 'MetricName, 'Name>, value: seq<string * string>) : WafWebAclState<'DefaultAction, 'MetricName, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : WafWebAclState<'DefaultAction, 'MetricName, 'Name>

        member _.Run(state: WafWebAclState<Present, Present, Present>) : aws.WafWebAcl.WafWebAcl =
            let config = aws.WafWebAcl.WafWebAclConfig()
            for setter in state.assignments do
                setter config
            aws.WafWebAcl.WafWebAcl(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafWebAcl: missing required arguments. Must call: default_action, metric_name, name.", 9999, IsError = true)>]
        member _.Run(_: WafWebAclState<_, _, _>) : aws.WafWebAcl.WafWebAcl =
            Unchecked.defaultof<aws.WafWebAcl.WafWebAcl>
