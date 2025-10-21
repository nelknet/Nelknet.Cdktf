namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2InstanceMetadataDefaultsState = { assignments: ResizeArray<aws.Ec2InstanceMetadataDefaults.Ec2InstanceMetadataDefaultsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_instance_metadata_defaults">aws_ec2_instance_metadata_defaults</a>.
    /// </summary>
    type Ec2InstanceMetadataDefaultsBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2InstanceMetadataDefaultsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : Ec2InstanceMetadataDefaultsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_instance_metadata_defaults#http_endpoint-1">Ec2InstanceMetadataDefaults#http_endpoint</a>.
        /// </summary>
        [<CustomOperation "http_endpoint">]
        member _.HttpEndpoint(state: Ec2InstanceMetadataDefaultsState, value: string) : Ec2InstanceMetadataDefaultsState =
            state.assignments.Add(fun config -> config.HttpEndpoint <- value)
            state : Ec2InstanceMetadataDefaultsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_instance_metadata_defaults#http_put_response_hop_limit-1">Ec2InstanceMetadataDefaults#http_put_response_hop_limit</a>.
        /// </summary>
        [<CustomOperation "http_put_response_hop_limit">]
        member _.HttpPutResponseHopLimit(state: Ec2InstanceMetadataDefaultsState, value: double) : Ec2InstanceMetadataDefaultsState =
            state.assignments.Add(fun config -> config.HttpPutResponseHopLimit <- value)
            state : Ec2InstanceMetadataDefaultsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_instance_metadata_defaults#http_tokens-1">Ec2InstanceMetadataDefaults#http_tokens</a>.
        /// </summary>
        [<CustomOperation "http_tokens">]
        member _.HttpTokens(state: Ec2InstanceMetadataDefaultsState, value: string) : Ec2InstanceMetadataDefaultsState =
            state.assignments.Add(fun config -> config.HttpTokens <- value)
            state : Ec2InstanceMetadataDefaultsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_instance_metadata_defaults#instance_metadata_tags-1">Ec2InstanceMetadataDefaults#instance_metadata_tags</a>.
        /// </summary>
        [<CustomOperation "instance_metadata_tags">]
        member _.InstanceMetadataTags(state: Ec2InstanceMetadataDefaultsState, value: string) : Ec2InstanceMetadataDefaultsState =
            state.assignments.Add(fun config -> config.InstanceMetadataTags <- value)
            state : Ec2InstanceMetadataDefaultsState

        member _.Run(state: Ec2InstanceMetadataDefaultsState) : aws.Ec2InstanceMetadataDefaults.Ec2InstanceMetadataDefaults =
            let config = aws.Ec2InstanceMetadataDefaults.Ec2InstanceMetadataDefaultsConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2InstanceMetadataDefaults.Ec2InstanceMetadataDefaults(StackContext.get (), logicalId, config)
