namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type XrayGroupState<'FilterExpression, 'GroupName> = { assignments: ResizeArray<aws.XrayGroup.XrayGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_group">aws_xray_group</a>.
    /// </summary>
    type XrayGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : XrayGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : XrayGroupState<Missing, Missing>)

        member _.Zero(()) : XrayGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : XrayGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_group#filter_expression-1">XrayGroup#filter_expression</a>.
        /// </summary>
        [<CustomOperation "filter_expression">]
        member _.FilterExpression(state: XrayGroupState<Missing, 'GroupName>, value: string) : XrayGroupState<Present, 'GroupName> =
            state.assignments.Add(fun config -> config.FilterExpression <- value)
            ({ assignments = state.assignments } : XrayGroupState<Present, 'GroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_group#group_name-1">XrayGroup#group_name</a>.
        /// </summary>
        [<CustomOperation "group_name">]
        member _.GroupName(state: XrayGroupState<'FilterExpression, Missing>, value: string) : XrayGroupState<'FilterExpression, Present> =
            state.assignments.Add(fun config -> config.GroupName <- value)
            ({ assignments = state.assignments } : XrayGroupState<'FilterExpression, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_group#id-1">XrayGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: XrayGroupState<'FilterExpression, 'GroupName>, value: string) : XrayGroupState<'FilterExpression, 'GroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : XrayGroupState<'FilterExpression, 'GroupName>

        /// <summary>
        /// insights_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_group#insights_configuration-1">XrayGroup#insights_configuration</a>
        /// </summary>
        [<CustomOperation "insights_configuration">]
        member _.InsightsConfiguration(state: XrayGroupState<'FilterExpression, 'GroupName>, value: aws.XrayGroup.XrayGroupInsightsConfiguration) : XrayGroupState<'FilterExpression, 'GroupName> =
            state.assignments.Add(fun config -> config.InsightsConfiguration <- value)
            state : XrayGroupState<'FilterExpression, 'GroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_group#tags-1">XrayGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: XrayGroupState<'FilterExpression, 'GroupName>, value: seq<string * string>) : XrayGroupState<'FilterExpression, 'GroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : XrayGroupState<'FilterExpression, 'GroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/xray_group#tags_all-1">XrayGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: XrayGroupState<'FilterExpression, 'GroupName>, value: seq<string * string>) : XrayGroupState<'FilterExpression, 'GroupName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : XrayGroupState<'FilterExpression, 'GroupName>

        member _.Run(state: XrayGroupState<Present, Present>) : aws.XrayGroup.XrayGroup =
            let config = aws.XrayGroup.XrayGroupConfig()
            for setter in state.assignments do
                setter config
            aws.XrayGroup.XrayGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.xrayGroup: missing required arguments. Must call: filter_expression, group_name.", 9999, IsError = true)>]
        member _.Run(_: XrayGroupState<_, _>) : aws.XrayGroup.XrayGroup =
            Unchecked.defaultof<aws.XrayGroup.XrayGroup>
