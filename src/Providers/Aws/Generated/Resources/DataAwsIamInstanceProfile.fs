namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsIamInstanceProfileState<'Name> = { assignments: ResizeArray<aws.DataAwsIamInstanceProfile.DataAwsIamInstanceProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_instance_profile">aws_iam_instance_profile</a>.
    /// </summary>
    type DataAwsIamInstanceProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsIamInstanceProfileState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsIamInstanceProfileState<Missing>)

        member _.Zero(()) : DataAwsIamInstanceProfileState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsIamInstanceProfileState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_instance_profile#name-1">DataAwsIamInstanceProfile#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsIamInstanceProfileState<Missing>, value: string) : DataAwsIamInstanceProfileState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsIamInstanceProfileState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_instance_profile#id-1">DataAwsIamInstanceProfile#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsIamInstanceProfileState<'Name>, value: string) : DataAwsIamInstanceProfileState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsIamInstanceProfileState<'Name>

        member _.Run(state: DataAwsIamInstanceProfileState<Present>) : aws.DataAwsIamInstanceProfile.DataAwsIamInstanceProfile =
            let config = aws.DataAwsIamInstanceProfile.DataAwsIamInstanceProfileConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsIamInstanceProfile.DataAwsIamInstanceProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsIamInstanceProfile: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsIamInstanceProfileState<_>) : aws.DataAwsIamInstanceProfile.DataAwsIamInstanceProfile =
            Unchecked.defaultof<aws.DataAwsIamInstanceProfile.DataAwsIamInstanceProfile>
