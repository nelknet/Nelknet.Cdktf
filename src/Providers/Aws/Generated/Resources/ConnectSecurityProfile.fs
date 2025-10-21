namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConnectSecurityProfileState<'InstanceId, 'Name> = { assignments: ResizeArray<aws.ConnectSecurityProfile.ConnectSecurityProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_security_profile">aws_connect_security_profile</a>.
    /// </summary>
    type ConnectSecurityProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConnectSecurityProfileState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectSecurityProfileState<Missing, Missing>)

        member _.Zero(()) : ConnectSecurityProfileState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectSecurityProfileState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_security_profile#instance_id-1">ConnectSecurityProfile#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: ConnectSecurityProfileState<Missing, 'Name>, value: string) : ConnectSecurityProfileState<Present, 'Name> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : ConnectSecurityProfileState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_security_profile#name-1">ConnectSecurityProfile#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ConnectSecurityProfileState<'InstanceId, Missing>, value: string) : ConnectSecurityProfileState<'InstanceId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ConnectSecurityProfileState<'InstanceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_security_profile#description-1">ConnectSecurityProfile#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ConnectSecurityProfileState<'InstanceId, 'Name>, value: string) : ConnectSecurityProfileState<'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ConnectSecurityProfileState<'InstanceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_security_profile#id-1">ConnectSecurityProfile#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ConnectSecurityProfileState<'InstanceId, 'Name>, value: string) : ConnectSecurityProfileState<'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ConnectSecurityProfileState<'InstanceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_security_profile#permissions-1">ConnectSecurityProfile#permissions</a>.
        /// </summary>
        [<CustomOperation "permissions">]
        member _.Permissions(state: ConnectSecurityProfileState<'InstanceId, 'Name>, value: seq<string>) : ConnectSecurityProfileState<'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.Permissions <- (value |> Seq.toArray))
            state : ConnectSecurityProfileState<'InstanceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_security_profile#tags-1">ConnectSecurityProfile#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ConnectSecurityProfileState<'InstanceId, 'Name>, value: seq<string * string>) : ConnectSecurityProfileState<'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ConnectSecurityProfileState<'InstanceId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_security_profile#tags_all-1">ConnectSecurityProfile#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ConnectSecurityProfileState<'InstanceId, 'Name>, value: seq<string * string>) : ConnectSecurityProfileState<'InstanceId, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ConnectSecurityProfileState<'InstanceId, 'Name>

        member _.Run(state: ConnectSecurityProfileState<Present, Present>) : aws.ConnectSecurityProfile.ConnectSecurityProfile =
            let config = aws.ConnectSecurityProfile.ConnectSecurityProfileConfig()
            for setter in state.assignments do
                setter config
            aws.ConnectSecurityProfile.ConnectSecurityProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.connectSecurityProfile: missing required arguments. Must call: instance_id, name.", 9999, IsError = true)>]
        member _.Run(_: ConnectSecurityProfileState<_, _>) : aws.ConnectSecurityProfile.ConnectSecurityProfile =
            Unchecked.defaultof<aws.ConnectSecurityProfile.ConnectSecurityProfile>
