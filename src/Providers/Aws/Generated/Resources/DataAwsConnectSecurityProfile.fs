namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsConnectSecurityProfileState<'InstanceId> = { assignments: ResizeArray<aws.DataAwsConnectSecurityProfile.DataAwsConnectSecurityProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_security_profile">aws_connect_security_profile</a>.
    /// </summary>
    type DataAwsConnectSecurityProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsConnectSecurityProfileState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsConnectSecurityProfileState<Missing>)

        member _.Zero(()) : DataAwsConnectSecurityProfileState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsConnectSecurityProfileState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_security_profile#instance_id-1">DataAwsConnectSecurityProfile#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: DataAwsConnectSecurityProfileState<Missing>, value: string) : DataAwsConnectSecurityProfileState<Present> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : DataAwsConnectSecurityProfileState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_security_profile#id-1">DataAwsConnectSecurityProfile#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsConnectSecurityProfileState<'InstanceId>, value: string) : DataAwsConnectSecurityProfileState<'InstanceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsConnectSecurityProfileState<'InstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_security_profile#name-1">DataAwsConnectSecurityProfile#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsConnectSecurityProfileState<'InstanceId>, value: string) : DataAwsConnectSecurityProfileState<'InstanceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsConnectSecurityProfileState<'InstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_security_profile#security_profile_id-1">DataAwsConnectSecurityProfile#security_profile_id</a>.
        /// </summary>
        [<CustomOperation "security_profile_id">]
        member _.SecurityProfileId(state: DataAwsConnectSecurityProfileState<'InstanceId>, value: string) : DataAwsConnectSecurityProfileState<'InstanceId> =
            state.assignments.Add(fun config -> config.SecurityProfileId <- value)
            state : DataAwsConnectSecurityProfileState<'InstanceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_security_profile#tags-1">DataAwsConnectSecurityProfile#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsConnectSecurityProfileState<'InstanceId>, value: seq<string * string>) : DataAwsConnectSecurityProfileState<'InstanceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsConnectSecurityProfileState<'InstanceId>

        member _.Run(state: DataAwsConnectSecurityProfileState<Present>) : aws.DataAwsConnectSecurityProfile.DataAwsConnectSecurityProfile =
            let config = aws.DataAwsConnectSecurityProfile.DataAwsConnectSecurityProfileConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsConnectSecurityProfile.DataAwsConnectSecurityProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsConnectSecurityProfile: missing required arguments. Must call: instance_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsConnectSecurityProfileState<_>) : aws.DataAwsConnectSecurityProfile.DataAwsConnectSecurityProfile =
            Unchecked.defaultof<aws.DataAwsConnectSecurityProfile.DataAwsConnectSecurityProfile>
