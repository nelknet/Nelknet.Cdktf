namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsIamInstanceProfilesState<'RoleName> = { assignments: ResizeArray<aws.DataAwsIamInstanceProfiles.DataAwsIamInstanceProfilesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_instance_profiles">aws_iam_instance_profiles</a>.
    /// </summary>
    type DataAwsIamInstanceProfilesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsIamInstanceProfilesState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsIamInstanceProfilesState<Missing>)

        member _.Zero(()) : DataAwsIamInstanceProfilesState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsIamInstanceProfilesState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_instance_profiles#role_name-1">DataAwsIamInstanceProfiles#role_name</a>.
        /// </summary>
        [<CustomOperation "role_name">]
        member _.RoleName(state: DataAwsIamInstanceProfilesState<Missing>, value: string) : DataAwsIamInstanceProfilesState<Present> =
            state.assignments.Add(fun config -> config.RoleName <- value)
            ({ assignments = state.assignments } : DataAwsIamInstanceProfilesState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_instance_profiles#id-1">DataAwsIamInstanceProfiles#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsIamInstanceProfilesState<'RoleName>, value: string) : DataAwsIamInstanceProfilesState<'RoleName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsIamInstanceProfilesState<'RoleName>

        member _.Run(state: DataAwsIamInstanceProfilesState<Present>) : aws.DataAwsIamInstanceProfiles.DataAwsIamInstanceProfiles =
            let config = aws.DataAwsIamInstanceProfiles.DataAwsIamInstanceProfilesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsIamInstanceProfiles.DataAwsIamInstanceProfiles(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsIamInstanceProfiles: missing required arguments. Must call: role_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsIamInstanceProfilesState<_>) : aws.DataAwsIamInstanceProfiles.DataAwsIamInstanceProfiles =
            Unchecked.defaultof<aws.DataAwsIamInstanceProfiles.DataAwsIamInstanceProfiles>
