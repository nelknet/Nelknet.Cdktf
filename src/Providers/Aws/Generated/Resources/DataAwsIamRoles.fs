namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsIamRolesState = { assignments: ResizeArray<aws.DataAwsIamRoles.DataAwsIamRolesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_roles">aws_iam_roles</a>.
    /// </summary>
    type DataAwsIamRolesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsIamRolesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsIamRolesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_roles#id-1">DataAwsIamRoles#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsIamRolesState, value: string) : DataAwsIamRolesState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsIamRolesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_roles#name_regex-1">DataAwsIamRoles#name_regex</a>.
        /// </summary>
        [<CustomOperation "name_regex">]
        member _.NameRegex(state: DataAwsIamRolesState, value: string) : DataAwsIamRolesState =
            state.assignments.Add(fun config -> config.NameRegex <- value)
            state : DataAwsIamRolesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_roles#path_prefix-1">DataAwsIamRoles#path_prefix</a>.
        /// </summary>
        [<CustomOperation "path_prefix">]
        member _.PathPrefix(state: DataAwsIamRolesState, value: string) : DataAwsIamRolesState =
            state.assignments.Add(fun config -> config.PathPrefix <- value)
            state : DataAwsIamRolesState

        member _.Run(state: DataAwsIamRolesState) : aws.DataAwsIamRoles.DataAwsIamRoles =
            let config = aws.DataAwsIamRoles.DataAwsIamRolesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsIamRoles.DataAwsIamRoles(StackContext.get (), logicalId, config)
