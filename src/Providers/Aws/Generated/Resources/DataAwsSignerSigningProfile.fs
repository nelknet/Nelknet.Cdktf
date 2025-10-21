namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSignerSigningProfileState<'Name> = { assignments: ResizeArray<aws.DataAwsSignerSigningProfile.DataAwsSignerSigningProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/signer_signing_profile">aws_signer_signing_profile</a>.
    /// </summary>
    type DataAwsSignerSigningProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSignerSigningProfileState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSignerSigningProfileState<Missing>)

        member _.Zero(()) : DataAwsSignerSigningProfileState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSignerSigningProfileState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/signer_signing_profile#name-1">DataAwsSignerSigningProfile#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsSignerSigningProfileState<Missing>, value: string) : DataAwsSignerSigningProfileState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsSignerSigningProfileState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/signer_signing_profile#id-1">DataAwsSignerSigningProfile#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsSignerSigningProfileState<'Name>, value: string) : DataAwsSignerSigningProfileState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsSignerSigningProfileState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/signer_signing_profile#tags-1">DataAwsSignerSigningProfile#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsSignerSigningProfileState<'Name>, value: seq<string * string>) : DataAwsSignerSigningProfileState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsSignerSigningProfileState<'Name>

        member _.Run(state: DataAwsSignerSigningProfileState<Present>) : aws.DataAwsSignerSigningProfile.DataAwsSignerSigningProfile =
            let config = aws.DataAwsSignerSigningProfile.DataAwsSignerSigningProfileConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSignerSigningProfile.DataAwsSignerSigningProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSignerSigningProfile: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSignerSigningProfileState<_>) : aws.DataAwsSignerSigningProfile.DataAwsSignerSigningProfile =
            Unchecked.defaultof<aws.DataAwsSignerSigningProfile.DataAwsSignerSigningProfile>
