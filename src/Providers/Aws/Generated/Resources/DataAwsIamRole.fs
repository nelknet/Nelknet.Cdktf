namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsIamRoleState<'Name> = { assignments: ResizeArray<aws.DataAwsIamRole.DataAwsIamRoleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_role">aws_iam_role</a>.
    /// </summary>
    type DataAwsIamRoleBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsIamRoleState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsIamRoleState<Missing>)

        member _.Zero(()) : DataAwsIamRoleState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsIamRoleState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_role#name-1">DataAwsIamRole#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsIamRoleState<Missing>, value: string) : DataAwsIamRoleState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsIamRoleState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_role#id-1">DataAwsIamRole#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsIamRoleState<'Name>, value: string) : DataAwsIamRoleState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsIamRoleState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_role#tags-1">DataAwsIamRole#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsIamRoleState<'Name>, value: seq<string * string>) : DataAwsIamRoleState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsIamRoleState<'Name>

        member _.Run(state: DataAwsIamRoleState<Present>) : aws.DataAwsIamRole.DataAwsIamRole =
            let config = aws.DataAwsIamRole.DataAwsIamRoleConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsIamRole.DataAwsIamRole(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsIamRole: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsIamRoleState<_>) : aws.DataAwsIamRole.DataAwsIamRole =
            Unchecked.defaultof<aws.DataAwsIamRole.DataAwsIamRole>
