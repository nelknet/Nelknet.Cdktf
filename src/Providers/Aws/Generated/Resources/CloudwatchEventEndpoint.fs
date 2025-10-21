namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudwatchEventEndpointState<'EventBus, 'Name, 'RoutingConfig> = { assignments: ResizeArray<aws.CloudwatchEventEndpoint.CloudwatchEventEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_endpoint">aws_cloudwatch_event_endpoint</a>.
    /// </summary>
    type CloudwatchEventEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudwatchEventEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchEventEndpointState<Missing, Missing, Missing>)

        member _.Zero(()) : CloudwatchEventEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchEventEndpointState<Missing, Missing, Missing>)

        /// <summary>
        /// event_bus block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_endpoint#event_bus-1">CloudwatchEventEndpoint#event_bus</a> Accepts: aws.IResolvable | aws.CloudwatchEventEndpoint.CloudwatchEventEndpointEventBus[]
        /// </summary>
        [<CustomOperation "event_bus">]
        member _.EventBus(state: CloudwatchEventEndpointState<Missing, 'Name, 'RoutingConfig>, value: HashiCorp.Cdktf.IResolvable) : CloudwatchEventEndpointState<Present, 'Name, 'RoutingConfig> =
            state.assignments.Add(fun config -> config.EventBus <- value)
            ({ assignments = state.assignments } : CloudwatchEventEndpointState<Present, 'Name, 'RoutingConfig>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_endpoint#name-1">CloudwatchEventEndpoint#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CloudwatchEventEndpointState<'EventBus, Missing, 'RoutingConfig>, value: string) : CloudwatchEventEndpointState<'EventBus, Present, 'RoutingConfig> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CloudwatchEventEndpointState<'EventBus, Present, 'RoutingConfig>)

        /// <summary>
        /// routing_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_endpoint#routing_config-1">CloudwatchEventEndpoint#routing_config</a>
        /// </summary>
        [<CustomOperation "routing_config">]
        member _.RoutingConfig(state: CloudwatchEventEndpointState<'EventBus, 'Name, Missing>, value: aws.CloudwatchEventEndpoint.CloudwatchEventEndpointRoutingConfig) : CloudwatchEventEndpointState<'EventBus, 'Name, Present> =
            state.assignments.Add(fun config -> config.RoutingConfig <- value)
            ({ assignments = state.assignments } : CloudwatchEventEndpointState<'EventBus, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_endpoint#description-1">CloudwatchEventEndpoint#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: CloudwatchEventEndpointState<'EventBus, 'Name, 'RoutingConfig>, value: string) : CloudwatchEventEndpointState<'EventBus, 'Name, 'RoutingConfig> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : CloudwatchEventEndpointState<'EventBus, 'Name, 'RoutingConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_endpoint#id-1">CloudwatchEventEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudwatchEventEndpointState<'EventBus, 'Name, 'RoutingConfig>, value: string) : CloudwatchEventEndpointState<'EventBus, 'Name, 'RoutingConfig> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudwatchEventEndpointState<'EventBus, 'Name, 'RoutingConfig>

        /// <summary>
        /// replication_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_endpoint#replication_config-1">CloudwatchEventEndpoint#replication_config</a>
        /// </summary>
        [<CustomOperation "replication_config">]
        member _.ReplicationConfig(state: CloudwatchEventEndpointState<'EventBus, 'Name, 'RoutingConfig>, value: aws.CloudwatchEventEndpoint.CloudwatchEventEndpointReplicationConfig) : CloudwatchEventEndpointState<'EventBus, 'Name, 'RoutingConfig> =
            state.assignments.Add(fun config -> config.ReplicationConfig <- value)
            state : CloudwatchEventEndpointState<'EventBus, 'Name, 'RoutingConfig>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_event_endpoint#role_arn-1">CloudwatchEventEndpoint#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: CloudwatchEventEndpointState<'EventBus, 'Name, 'RoutingConfig>, value: string) : CloudwatchEventEndpointState<'EventBus, 'Name, 'RoutingConfig> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            state : CloudwatchEventEndpointState<'EventBus, 'Name, 'RoutingConfig>

        member _.Run(state: CloudwatchEventEndpointState<Present, Present, Present>) : aws.CloudwatchEventEndpoint.CloudwatchEventEndpoint =
            let config = aws.CloudwatchEventEndpoint.CloudwatchEventEndpointConfig()
            for setter in state.assignments do
                setter config
            aws.CloudwatchEventEndpoint.CloudwatchEventEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudwatchEventEndpoint: missing required arguments. Must call: event_bus, name, routing_config.", 9999, IsError = true)>]
        member _.Run(_: CloudwatchEventEndpointState<_, _, _>) : aws.CloudwatchEventEndpoint.CloudwatchEventEndpoint =
            Unchecked.defaultof<aws.CloudwatchEventEndpoint.CloudwatchEventEndpoint>
