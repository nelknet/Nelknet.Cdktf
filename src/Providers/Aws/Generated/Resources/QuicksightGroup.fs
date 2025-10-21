namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type QuicksightGroupState<'GroupName> = { assignments: ResizeArray<aws.QuicksightGroup.QuicksightGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_group">aws_quicksight_group</a>.
    /// </summary>
    type QuicksightGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : QuicksightGroupState<Missing> =
            ({ assignments = ResizeArray() } : QuicksightGroupState<Missing>)

        member _.Zero(()) : QuicksightGroupState<Missing> =
            ({ assignments = ResizeArray() } : QuicksightGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_group#group_name-1">QuicksightGroup#group_name</a>.
        /// </summary>
        [<CustomOperation "group_name">]
        member _.GroupName(state: QuicksightGroupState<Missing>, value: string) : QuicksightGroupState<Present> =
            state.assignments.Add(fun config -> config.GroupName <- value)
            ({ assignments = state.assignments } : QuicksightGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_group#aws_account_id-1">QuicksightGroup#aws_account_id</a>.
        /// </summary>
        [<CustomOperation "aws_account_id">]
        member _.AwsAccountId(state: QuicksightGroupState<'GroupName>, value: string) : QuicksightGroupState<'GroupName> =
            state.assignments.Add(fun config -> config.AwsAccountId <- value)
            state : QuicksightGroupState<'GroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_group#description-1">QuicksightGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: QuicksightGroupState<'GroupName>, value: string) : QuicksightGroupState<'GroupName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : QuicksightGroupState<'GroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_group#id-1">QuicksightGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: QuicksightGroupState<'GroupName>, value: string) : QuicksightGroupState<'GroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : QuicksightGroupState<'GroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_group#namespace-1">QuicksightGroup#namespace</a>.
        /// </summary>
        [<CustomOperation "namespace">]
        member _.Namespace(state: QuicksightGroupState<'GroupName>, value: string) : QuicksightGroupState<'GroupName> =
            state.assignments.Add(fun config -> config.Namespace <- value)
            state : QuicksightGroupState<'GroupName>

        member _.Run(state: QuicksightGroupState<Present>) : aws.QuicksightGroup.QuicksightGroup =
            let config = aws.QuicksightGroup.QuicksightGroupConfig()
            for setter in state.assignments do
                setter config
            aws.QuicksightGroup.QuicksightGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.quicksightGroup: missing required arguments. Must call: group_name.", 9999, IsError = true)>]
        member _.Run(_: QuicksightGroupState<_>) : aws.QuicksightGroup.QuicksightGroup =
            Unchecked.defaultof<aws.QuicksightGroup.QuicksightGroup>
