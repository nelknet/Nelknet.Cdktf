namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2HostState<'AvailabilityZone> = { assignments: ResizeArray<aws.Ec2Host.Ec2HostConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_host">aws_ec2_host</a>.
    /// </summary>
    type Ec2HostBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2HostState<Missing> =
            ({ assignments = ResizeArray() } : Ec2HostState<Missing>)

        member _.Zero(()) : Ec2HostState<Missing> =
            ({ assignments = ResizeArray() } : Ec2HostState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_host#availability_zone-1">Ec2Host#availability_zone</a>.
        /// </summary>
        [<CustomOperation "availability_zone">]
        member _.AvailabilityZone(state: Ec2HostState<Missing>, value: string) : Ec2HostState<Present> =
            state.assignments.Add(fun config -> config.AvailabilityZone <- value)
            ({ assignments = state.assignments } : Ec2HostState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_host#asset_id-1">Ec2Host#asset_id</a>.
        /// </summary>
        [<CustomOperation "asset_id">]
        member _.AssetId(state: Ec2HostState<'AvailabilityZone>, value: string) : Ec2HostState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.AssetId <- value)
            state : Ec2HostState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_host#auto_placement-1">Ec2Host#auto_placement</a>.
        /// </summary>
        [<CustomOperation "auto_placement">]
        member _.AutoPlacement(state: Ec2HostState<'AvailabilityZone>, value: string) : Ec2HostState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.AutoPlacement <- value)
            state : Ec2HostState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_host#host_recovery-1">Ec2Host#host_recovery</a>.
        /// </summary>
        [<CustomOperation "host_recovery">]
        member _.HostRecovery(state: Ec2HostState<'AvailabilityZone>, value: string) : Ec2HostState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.HostRecovery <- value)
            state : Ec2HostState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_host#id-1">Ec2Host#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2HostState<'AvailabilityZone>, value: string) : Ec2HostState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2HostState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_host#instance_family-1">Ec2Host#instance_family</a>.
        /// </summary>
        [<CustomOperation "instance_family">]
        member _.InstanceFamily(state: Ec2HostState<'AvailabilityZone>, value: string) : Ec2HostState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.InstanceFamily <- value)
            state : Ec2HostState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_host#instance_type-1">Ec2Host#instance_type</a>.
        /// </summary>
        [<CustomOperation "instance_type">]
        member _.InstanceType(state: Ec2HostState<'AvailabilityZone>, value: string) : Ec2HostState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.InstanceType <- value)
            state : Ec2HostState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_host#outpost_arn-1">Ec2Host#outpost_arn</a>.
        /// </summary>
        [<CustomOperation "outpost_arn">]
        member _.OutpostArn(state: Ec2HostState<'AvailabilityZone>, value: string) : Ec2HostState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.OutpostArn <- value)
            state : Ec2HostState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_host#tags-1">Ec2Host#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Ec2HostState<'AvailabilityZone>, value: seq<string * string>) : Ec2HostState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Ec2HostState<'AvailabilityZone>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_host#tags_all-1">Ec2Host#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Ec2HostState<'AvailabilityZone>, value: seq<string * string>) : Ec2HostState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Ec2HostState<'AvailabilityZone>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_host#timeouts-1">Ec2Host#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Ec2HostState<'AvailabilityZone>, value: aws.Ec2Host.Ec2HostTimeouts) : Ec2HostState<'AvailabilityZone> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Ec2HostState<'AvailabilityZone>

        member _.Run(state: Ec2HostState<Present>) : aws.Ec2Host.Ec2Host =
            let config = aws.Ec2Host.Ec2HostConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2Host.Ec2Host(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2Host: missing required arguments. Must call: availability_zone.", 9999, IsError = true)>]
        member _.Run(_: Ec2HostState<_>) : aws.Ec2Host.Ec2Host =
            Unchecked.defaultof<aws.Ec2Host.Ec2Host>
