namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LightsailInstancePublicPortsState<'InstanceName, 'PortInfo> = { assignments: ResizeArray<aws.LightsailInstancePublicPorts.LightsailInstancePublicPortsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_instance_public_ports">aws_lightsail_instance_public_ports</a>.
    /// </summary>
    type LightsailInstancePublicPortsBuilder(logicalId: string) =
        member _.Yield(_: unit) : LightsailInstancePublicPortsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailInstancePublicPortsState<Missing, Missing>)

        member _.Zero(()) : LightsailInstancePublicPortsState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailInstancePublicPortsState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_instance_public_ports#instance_name-1">LightsailInstancePublicPorts#instance_name</a>.
        /// </summary>
        [<CustomOperation "instance_name">]
        member _.InstanceName(state: LightsailInstancePublicPortsState<Missing, 'PortInfo>, value: string) : LightsailInstancePublicPortsState<Present, 'PortInfo> =
            state.assignments.Add(fun config -> config.InstanceName <- value)
            ({ assignments = state.assignments } : LightsailInstancePublicPortsState<Present, 'PortInfo>)

        /// <summary>
        /// port_info block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_instance_public_ports#port_info-1">LightsailInstancePublicPorts#port_info</a> Accepts: aws.IResolvable | aws.LightsailInstancePublicPorts.LightsailInstancePublicPortsPortInfo[]
        /// </summary>
        [<CustomOperation "port_info">]
        member _.PortInfo(state: LightsailInstancePublicPortsState<'InstanceName, Missing>, value: HashiCorp.Cdktf.IResolvable) : LightsailInstancePublicPortsState<'InstanceName, Present> =
            state.assignments.Add(fun config -> config.PortInfo <- value)
            ({ assignments = state.assignments } : LightsailInstancePublicPortsState<'InstanceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_instance_public_ports#id-1">LightsailInstancePublicPorts#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LightsailInstancePublicPortsState<'InstanceName, 'PortInfo>, value: string) : LightsailInstancePublicPortsState<'InstanceName, 'PortInfo> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LightsailInstancePublicPortsState<'InstanceName, 'PortInfo>

        member _.Run(state: LightsailInstancePublicPortsState<Present, Present>) : aws.LightsailInstancePublicPorts.LightsailInstancePublicPorts =
            let config = aws.LightsailInstancePublicPorts.LightsailInstancePublicPortsConfig()
            for setter in state.assignments do
                setter config
            aws.LightsailInstancePublicPorts.LightsailInstancePublicPorts(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lightsailInstancePublicPorts: missing required arguments. Must call: instance_name, port_info.", 9999, IsError = true)>]
        member _.Run(_: LightsailInstancePublicPortsState<_, _>) : aws.LightsailInstancePublicPorts.LightsailInstancePublicPorts =
            Unchecked.defaultof<aws.LightsailInstancePublicPorts.LightsailInstancePublicPorts>
