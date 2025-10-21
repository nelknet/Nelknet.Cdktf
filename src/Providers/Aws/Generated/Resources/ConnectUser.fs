namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConnectUserState<'InstanceId, 'Name, 'PhoneConfig, 'RoutingProfileId, 'SecurityProfileIds> = { assignments: ResizeArray<aws.ConnectUser.ConnectUserConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user">aws_connect_user</a>.
    /// </summary>
    type ConnectUserBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConnectUserState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectUserState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ConnectUserState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectUserState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user#instance_id-1">ConnectUser#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: ConnectUserState<Missing, 'Name, 'PhoneConfig, 'RoutingProfileId, 'SecurityProfileIds>, value: string) : ConnectUserState<Present, 'Name, 'PhoneConfig, 'RoutingProfileId, 'SecurityProfileIds> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : ConnectUserState<Present, 'Name, 'PhoneConfig, 'RoutingProfileId, 'SecurityProfileIds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user#name-1">ConnectUser#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ConnectUserState<'InstanceId, Missing, 'PhoneConfig, 'RoutingProfileId, 'SecurityProfileIds>, value: string) : ConnectUserState<'InstanceId, Present, 'PhoneConfig, 'RoutingProfileId, 'SecurityProfileIds> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ConnectUserState<'InstanceId, Present, 'PhoneConfig, 'RoutingProfileId, 'SecurityProfileIds>)

        /// <summary>
        /// phone_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user#phone_config-1">ConnectUser#phone_config</a>
        /// </summary>
        [<CustomOperation "phone_config">]
        member _.PhoneConfig(state: ConnectUserState<'InstanceId, 'Name, Missing, 'RoutingProfileId, 'SecurityProfileIds>, value: aws.ConnectUser.ConnectUserPhoneConfig) : ConnectUserState<'InstanceId, 'Name, Present, 'RoutingProfileId, 'SecurityProfileIds> =
            state.assignments.Add(fun config -> config.PhoneConfig <- value)
            ({ assignments = state.assignments } : ConnectUserState<'InstanceId, 'Name, Present, 'RoutingProfileId, 'SecurityProfileIds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user#routing_profile_id-1">ConnectUser#routing_profile_id</a>.
        /// </summary>
        [<CustomOperation "routing_profile_id">]
        member _.RoutingProfileId(state: ConnectUserState<'InstanceId, 'Name, 'PhoneConfig, Missing, 'SecurityProfileIds>, value: string) : ConnectUserState<'InstanceId, 'Name, 'PhoneConfig, Present, 'SecurityProfileIds> =
            state.assignments.Add(fun config -> config.RoutingProfileId <- value)
            ({ assignments = state.assignments } : ConnectUserState<'InstanceId, 'Name, 'PhoneConfig, Present, 'SecurityProfileIds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user#security_profile_ids-1">ConnectUser#security_profile_ids</a>.
        /// </summary>
        [<CustomOperation "security_profile_ids">]
        member _.SecurityProfileIds(state: ConnectUserState<'InstanceId, 'Name, 'PhoneConfig, 'RoutingProfileId, Missing>, value: seq<string>) : ConnectUserState<'InstanceId, 'Name, 'PhoneConfig, 'RoutingProfileId, Present> =
            state.assignments.Add(fun config -> config.SecurityProfileIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : ConnectUserState<'InstanceId, 'Name, 'PhoneConfig, 'RoutingProfileId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user#directory_user_id-1">ConnectUser#directory_user_id</a>.
        /// </summary>
        [<CustomOperation "directory_user_id">]
        member _.DirectoryUserId(state: ConnectUserState<'InstanceId, 'Name, 'PhoneConfig, 'RoutingProfileId, 'SecurityProfileIds>, value: string) : ConnectUserState<'InstanceId, 'Name, 'PhoneConfig, 'RoutingProfileId, 'SecurityProfileIds> =
            state.assignments.Add(fun config -> config.DirectoryUserId <- value)
            state : ConnectUserState<'InstanceId, 'Name, 'PhoneConfig, 'RoutingProfileId, 'SecurityProfileIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user#hierarchy_group_id-1">ConnectUser#hierarchy_group_id</a>.
        /// </summary>
        [<CustomOperation "hierarchy_group_id">]
        member _.HierarchyGroupId(state: ConnectUserState<'InstanceId, 'Name, 'PhoneConfig, 'RoutingProfileId, 'SecurityProfileIds>, value: string) : ConnectUserState<'InstanceId, 'Name, 'PhoneConfig, 'RoutingProfileId, 'SecurityProfileIds> =
            state.assignments.Add(fun config -> config.HierarchyGroupId <- value)
            state : ConnectUserState<'InstanceId, 'Name, 'PhoneConfig, 'RoutingProfileId, 'SecurityProfileIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user#id-1">ConnectUser#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ConnectUserState<'InstanceId, 'Name, 'PhoneConfig, 'RoutingProfileId, 'SecurityProfileIds>, value: string) : ConnectUserState<'InstanceId, 'Name, 'PhoneConfig, 'RoutingProfileId, 'SecurityProfileIds> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ConnectUserState<'InstanceId, 'Name, 'PhoneConfig, 'RoutingProfileId, 'SecurityProfileIds>

        /// <summary>
        /// identity_info block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user#identity_info-1">ConnectUser#identity_info</a>
        /// </summary>
        [<CustomOperation "identity_info">]
        member _.IdentityInfo(state: ConnectUserState<'InstanceId, 'Name, 'PhoneConfig, 'RoutingProfileId, 'SecurityProfileIds>, value: aws.ConnectUser.ConnectUserIdentityInfo) : ConnectUserState<'InstanceId, 'Name, 'PhoneConfig, 'RoutingProfileId, 'SecurityProfileIds> =
            state.assignments.Add(fun config -> config.IdentityInfo <- value)
            state : ConnectUserState<'InstanceId, 'Name, 'PhoneConfig, 'RoutingProfileId, 'SecurityProfileIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user#password-1">ConnectUser#password</a>.
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: ConnectUserState<'InstanceId, 'Name, 'PhoneConfig, 'RoutingProfileId, 'SecurityProfileIds>, value: string) : ConnectUserState<'InstanceId, 'Name, 'PhoneConfig, 'RoutingProfileId, 'SecurityProfileIds> =
            state.assignments.Add(fun config -> config.Password <- value)
            state : ConnectUserState<'InstanceId, 'Name, 'PhoneConfig, 'RoutingProfileId, 'SecurityProfileIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user#tags-1">ConnectUser#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ConnectUserState<'InstanceId, 'Name, 'PhoneConfig, 'RoutingProfileId, 'SecurityProfileIds>, value: seq<string * string>) : ConnectUserState<'InstanceId, 'Name, 'PhoneConfig, 'RoutingProfileId, 'SecurityProfileIds> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ConnectUserState<'InstanceId, 'Name, 'PhoneConfig, 'RoutingProfileId, 'SecurityProfileIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_user#tags_all-1">ConnectUser#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ConnectUserState<'InstanceId, 'Name, 'PhoneConfig, 'RoutingProfileId, 'SecurityProfileIds>, value: seq<string * string>) : ConnectUserState<'InstanceId, 'Name, 'PhoneConfig, 'RoutingProfileId, 'SecurityProfileIds> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ConnectUserState<'InstanceId, 'Name, 'PhoneConfig, 'RoutingProfileId, 'SecurityProfileIds>

        member _.Run(state: ConnectUserState<Present, Present, Present, Present, Present>) : aws.ConnectUser.ConnectUser =
            let config = aws.ConnectUser.ConnectUserConfig()
            for setter in state.assignments do
                setter config
            aws.ConnectUser.ConnectUser(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.connectUser: missing required arguments. Must call: instance_id, name, phone_config, routing_profile_id, security_profile_ids.", 9999, IsError = true)>]
        member _.Run(_: ConnectUserState<_, _, _, _, _>) : aws.ConnectUser.ConnectUser =
            Unchecked.defaultof<aws.ConnectUser.ConnectUser>
