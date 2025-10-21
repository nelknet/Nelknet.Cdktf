namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConnectRoutingProfileState<'DefaultOutboundQueueId, 'Description, 'InstanceId, 'MediaConcurrencies, 'Name> = { assignments: ResizeArray<aws.ConnectRoutingProfile.ConnectRoutingProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_routing_profile">aws_connect_routing_profile</a>.
    /// </summary>
    type ConnectRoutingProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConnectRoutingProfileState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectRoutingProfileState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ConnectRoutingProfileState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectRoutingProfileState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_routing_profile#default_outbound_queue_id-1">ConnectRoutingProfile#default_outbound_queue_id</a>.
        /// </summary>
        [<CustomOperation "default_outbound_queue_id">]
        member _.DefaultOutboundQueueId(state: ConnectRoutingProfileState<Missing, 'Description, 'InstanceId, 'MediaConcurrencies, 'Name>, value: string) : ConnectRoutingProfileState<Present, 'Description, 'InstanceId, 'MediaConcurrencies, 'Name> =
            state.assignments.Add(fun config -> config.DefaultOutboundQueueId <- value)
            ({ assignments = state.assignments } : ConnectRoutingProfileState<Present, 'Description, 'InstanceId, 'MediaConcurrencies, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_routing_profile#description-1">ConnectRoutingProfile#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ConnectRoutingProfileState<'DefaultOutboundQueueId, Missing, 'InstanceId, 'MediaConcurrencies, 'Name>, value: string) : ConnectRoutingProfileState<'DefaultOutboundQueueId, Present, 'InstanceId, 'MediaConcurrencies, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            ({ assignments = state.assignments } : ConnectRoutingProfileState<'DefaultOutboundQueueId, Present, 'InstanceId, 'MediaConcurrencies, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_routing_profile#instance_id-1">ConnectRoutingProfile#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: ConnectRoutingProfileState<'DefaultOutboundQueueId, 'Description, Missing, 'MediaConcurrencies, 'Name>, value: string) : ConnectRoutingProfileState<'DefaultOutboundQueueId, 'Description, Present, 'MediaConcurrencies, 'Name> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : ConnectRoutingProfileState<'DefaultOutboundQueueId, 'Description, Present, 'MediaConcurrencies, 'Name>)

        /// <summary>
        /// media_concurrencies block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_routing_profile#media_concurrencies-1">ConnectRoutingProfile#media_concurrencies</a> Accepts: aws.IResolvable | aws.ConnectRoutingProfile.ConnectRoutingProfileMediaConcurrencies[]
        /// </summary>
        [<CustomOperation "media_concurrencies">]
        member _.MediaConcurrencies(state: ConnectRoutingProfileState<'DefaultOutboundQueueId, 'Description, 'InstanceId, Missing, 'Name>, value: HashiCorp.Cdktf.IResolvable) : ConnectRoutingProfileState<'DefaultOutboundQueueId, 'Description, 'InstanceId, Present, 'Name> =
            state.assignments.Add(fun config -> config.MediaConcurrencies <- value)
            ({ assignments = state.assignments } : ConnectRoutingProfileState<'DefaultOutboundQueueId, 'Description, 'InstanceId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_routing_profile#name-1">ConnectRoutingProfile#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ConnectRoutingProfileState<'DefaultOutboundQueueId, 'Description, 'InstanceId, 'MediaConcurrencies, Missing>, value: string) : ConnectRoutingProfileState<'DefaultOutboundQueueId, 'Description, 'InstanceId, 'MediaConcurrencies, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ConnectRoutingProfileState<'DefaultOutboundQueueId, 'Description, 'InstanceId, 'MediaConcurrencies, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_routing_profile#id-1">ConnectRoutingProfile#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ConnectRoutingProfileState<'DefaultOutboundQueueId, 'Description, 'InstanceId, 'MediaConcurrencies, 'Name>, value: string) : ConnectRoutingProfileState<'DefaultOutboundQueueId, 'Description, 'InstanceId, 'MediaConcurrencies, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ConnectRoutingProfileState<'DefaultOutboundQueueId, 'Description, 'InstanceId, 'MediaConcurrencies, 'Name>

        /// <summary>
        /// queue_configs block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_routing_profile#queue_configs-1">ConnectRoutingProfile#queue_configs</a> Accepts: aws.IResolvable | aws.ConnectRoutingProfile.ConnectRoutingProfileQueueConfigs[]
        /// </summary>
        [<CustomOperation "queue_configs">]
        member _.QueueConfigs(state: ConnectRoutingProfileState<'DefaultOutboundQueueId, 'Description, 'InstanceId, 'MediaConcurrencies, 'Name>, value: HashiCorp.Cdktf.IResolvable) : ConnectRoutingProfileState<'DefaultOutboundQueueId, 'Description, 'InstanceId, 'MediaConcurrencies, 'Name> =
            state.assignments.Add(fun config -> config.QueueConfigs <- value)
            state : ConnectRoutingProfileState<'DefaultOutboundQueueId, 'Description, 'InstanceId, 'MediaConcurrencies, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_routing_profile#tags-1">ConnectRoutingProfile#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ConnectRoutingProfileState<'DefaultOutboundQueueId, 'Description, 'InstanceId, 'MediaConcurrencies, 'Name>, value: seq<string * string>) : ConnectRoutingProfileState<'DefaultOutboundQueueId, 'Description, 'InstanceId, 'MediaConcurrencies, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ConnectRoutingProfileState<'DefaultOutboundQueueId, 'Description, 'InstanceId, 'MediaConcurrencies, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_routing_profile#tags_all-1">ConnectRoutingProfile#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ConnectRoutingProfileState<'DefaultOutboundQueueId, 'Description, 'InstanceId, 'MediaConcurrencies, 'Name>, value: seq<string * string>) : ConnectRoutingProfileState<'DefaultOutboundQueueId, 'Description, 'InstanceId, 'MediaConcurrencies, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ConnectRoutingProfileState<'DefaultOutboundQueueId, 'Description, 'InstanceId, 'MediaConcurrencies, 'Name>

        member _.Run(state: ConnectRoutingProfileState<Present, Present, Present, Present, Present>) : aws.ConnectRoutingProfile.ConnectRoutingProfile =
            let config = aws.ConnectRoutingProfile.ConnectRoutingProfileConfig()
            for setter in state.assignments do
                setter config
            aws.ConnectRoutingProfile.ConnectRoutingProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.connectRoutingProfile: missing required arguments. Must call: default_outbound_queue_id, description, instance_id, media_concurrencies, name.", 9999, IsError = true)>]
        member _.Run(_: ConnectRoutingProfileState<_, _, _, _, _>) : aws.ConnectRoutingProfile.ConnectRoutingProfile =
            Unchecked.defaultof<aws.ConnectRoutingProfile.ConnectRoutingProfile>
