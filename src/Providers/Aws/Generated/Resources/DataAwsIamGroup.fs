namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsIamGroupState<'GroupName> = { assignments: ResizeArray<aws.DataAwsIamGroup.DataAwsIamGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_group">aws_iam_group</a>.
    /// </summary>
    type DataAwsIamGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsIamGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsIamGroupState<Missing>)

        member _.Zero(()) : DataAwsIamGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsIamGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_group#group_name-1">DataAwsIamGroup#group_name</a>.
        /// </summary>
        [<CustomOperation "group_name">]
        member _.GroupName(state: DataAwsIamGroupState<Missing>, value: string) : DataAwsIamGroupState<Present> =
            state.assignments.Add(fun config -> config.GroupName <- value)
            ({ assignments = state.assignments } : DataAwsIamGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_group#id-1">DataAwsIamGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsIamGroupState<'GroupName>, value: string) : DataAwsIamGroupState<'GroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsIamGroupState<'GroupName>

        member _.Run(state: DataAwsIamGroupState<Present>) : aws.DataAwsIamGroup.DataAwsIamGroup =
            let config = aws.DataAwsIamGroup.DataAwsIamGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsIamGroup.DataAwsIamGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsIamGroup: missing required arguments. Must call: group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsIamGroupState<_>) : aws.DataAwsIamGroup.DataAwsIamGroup =
            Unchecked.defaultof<aws.DataAwsIamGroup.DataAwsIamGroup>
