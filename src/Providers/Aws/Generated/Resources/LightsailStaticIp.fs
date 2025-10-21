namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LightsailStaticIpState<'Name> = { assignments: ResizeArray<aws.LightsailStaticIp.LightsailStaticIpConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_static_ip">aws_lightsail_static_ip</a>.
    /// </summary>
    type LightsailStaticIpBuilder(logicalId: string) =
        member _.Yield(_: unit) : LightsailStaticIpState<Missing> =
            ({ assignments = ResizeArray() } : LightsailStaticIpState<Missing>)

        member _.Zero(()) : LightsailStaticIpState<Missing> =
            ({ assignments = ResizeArray() } : LightsailStaticIpState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_static_ip#name-1">LightsailStaticIp#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LightsailStaticIpState<Missing>, value: string) : LightsailStaticIpState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LightsailStaticIpState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_static_ip#id-1">LightsailStaticIp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LightsailStaticIpState<'Name>, value: string) : LightsailStaticIpState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LightsailStaticIpState<'Name>

        member _.Run(state: LightsailStaticIpState<Present>) : aws.LightsailStaticIp.LightsailStaticIp =
            let config = aws.LightsailStaticIp.LightsailStaticIpConfig()
            for setter in state.assignments do
                setter config
            aws.LightsailStaticIp.LightsailStaticIp(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lightsailStaticIp: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: LightsailStaticIpState<_>) : aws.LightsailStaticIp.LightsailStaticIp =
            Unchecked.defaultof<aws.LightsailStaticIp.LightsailStaticIp>
