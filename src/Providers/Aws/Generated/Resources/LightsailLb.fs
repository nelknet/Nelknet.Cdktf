namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LightsailLbState<'InstancePort, 'Name> = { assignments: ResizeArray<aws.LightsailLb.LightsailLbConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb">aws_lightsail_lb</a>.
    /// </summary>
    type LightsailLbBuilder(logicalId: string) =
        member _.Yield(_: unit) : LightsailLbState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailLbState<Missing, Missing>)

        member _.Zero(()) : LightsailLbState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailLbState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb#instance_port-1">LightsailLb#instance_port</a>.
        /// </summary>
        [<CustomOperation "instance_port">]
        member _.InstancePort(state: LightsailLbState<Missing, 'Name>, value: double) : LightsailLbState<Present, 'Name> =
            state.assignments.Add(fun config -> config.InstancePort <- value)
            ({ assignments = state.assignments } : LightsailLbState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb#name-1">LightsailLb#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LightsailLbState<'InstancePort, Missing>, value: string) : LightsailLbState<'InstancePort, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LightsailLbState<'InstancePort, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb#health_check_path-1">LightsailLb#health_check_path</a>.
        /// </summary>
        [<CustomOperation "health_check_path">]
        member _.HealthCheckPath(state: LightsailLbState<'InstancePort, 'Name>, value: string) : LightsailLbState<'InstancePort, 'Name> =
            state.assignments.Add(fun config -> config.HealthCheckPath <- value)
            state : LightsailLbState<'InstancePort, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb#id-1">LightsailLb#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LightsailLbState<'InstancePort, 'Name>, value: string) : LightsailLbState<'InstancePort, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LightsailLbState<'InstancePort, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb#ip_address_type-1">LightsailLb#ip_address_type</a>.
        /// </summary>
        [<CustomOperation "ip_address_type">]
        member _.IpAddressType(state: LightsailLbState<'InstancePort, 'Name>, value: string) : LightsailLbState<'InstancePort, 'Name> =
            state.assignments.Add(fun config -> config.IpAddressType <- value)
            state : LightsailLbState<'InstancePort, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb#tags-1">LightsailLb#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LightsailLbState<'InstancePort, 'Name>, value: seq<string * string>) : LightsailLbState<'InstancePort, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LightsailLbState<'InstancePort, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb#tags_all-1">LightsailLb#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: LightsailLbState<'InstancePort, 'Name>, value: seq<string * string>) : LightsailLbState<'InstancePort, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : LightsailLbState<'InstancePort, 'Name>

        member _.Run(state: LightsailLbState<Present, Present>) : aws.LightsailLb.LightsailLb =
            let config = aws.LightsailLb.LightsailLbConfig()
            for setter in state.assignments do
                setter config
            aws.LightsailLb.LightsailLb(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lightsailLb: missing required arguments. Must call: instance_port, name.", 9999, IsError = true)>]
        member _.Run(_: LightsailLbState<_, _>) : aws.LightsailLb.LightsailLb =
            Unchecked.defaultof<aws.LightsailLb.LightsailLb>
