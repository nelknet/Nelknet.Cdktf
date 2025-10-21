namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsQuicksightGroupState<'GroupName> = { assignments: ResizeArray<aws.DataAwsQuicksightGroup.DataAwsQuicksightGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/quicksight_group">aws_quicksight_group</a>.
    /// </summary>
    type DataAwsQuicksightGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsQuicksightGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsQuicksightGroupState<Missing>)

        member _.Zero(()) : DataAwsQuicksightGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsQuicksightGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/quicksight_group#group_name-1">DataAwsQuicksightGroup#group_name</a>.
        /// </summary>
        [<CustomOperation "group_name">]
        member _.GroupName(state: DataAwsQuicksightGroupState<Missing>, value: string) : DataAwsQuicksightGroupState<Present> =
            state.assignments.Add(fun config -> config.GroupName <- value)
            ({ assignments = state.assignments } : DataAwsQuicksightGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/quicksight_group#aws_account_id-1">DataAwsQuicksightGroup#aws_account_id</a>.
        /// </summary>
        [<CustomOperation "aws_account_id">]
        member _.AwsAccountId(state: DataAwsQuicksightGroupState<'GroupName>, value: string) : DataAwsQuicksightGroupState<'GroupName> =
            state.assignments.Add(fun config -> config.AwsAccountId <- value)
            state : DataAwsQuicksightGroupState<'GroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/quicksight_group#id-1">DataAwsQuicksightGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsQuicksightGroupState<'GroupName>, value: string) : DataAwsQuicksightGroupState<'GroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsQuicksightGroupState<'GroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/quicksight_group#namespace-1">DataAwsQuicksightGroup#namespace</a>.
        /// </summary>
        [<CustomOperation "namespace">]
        member _.Namespace(state: DataAwsQuicksightGroupState<'GroupName>, value: string) : DataAwsQuicksightGroupState<'GroupName> =
            state.assignments.Add(fun config -> config.Namespace <- value)
            state : DataAwsQuicksightGroupState<'GroupName>

        member _.Run(state: DataAwsQuicksightGroupState<Present>) : aws.DataAwsQuicksightGroup.DataAwsQuicksightGroup =
            let config = aws.DataAwsQuicksightGroup.DataAwsQuicksightGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsQuicksightGroup.DataAwsQuicksightGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsQuicksightGroup: missing required arguments. Must call: group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsQuicksightGroupState<_>) : aws.DataAwsQuicksightGroup.DataAwsQuicksightGroup =
            Unchecked.defaultof<aws.DataAwsQuicksightGroup.DataAwsQuicksightGroup>
