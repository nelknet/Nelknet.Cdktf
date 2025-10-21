namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudhsmV2HsmState<'ClusterId> = { assignments: ResizeArray<aws.CloudhsmV2Hsm.CloudhsmV2HsmConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudhsm_v2_hsm">aws_cloudhsm_v2_hsm</a>.
    /// </summary>
    type CloudhsmV2HsmBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudhsmV2HsmState<Missing> =
            ({ assignments = ResizeArray() } : CloudhsmV2HsmState<Missing>)

        member _.Zero(()) : CloudhsmV2HsmState<Missing> =
            ({ assignments = ResizeArray() } : CloudhsmV2HsmState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudhsm_v2_hsm#cluster_id-1">CloudhsmV2Hsm#cluster_id</a>.
        /// </summary>
        [<CustomOperation "cluster_id">]
        member _.ClusterId(state: CloudhsmV2HsmState<Missing>, value: string) : CloudhsmV2HsmState<Present> =
            state.assignments.Add(fun config -> config.ClusterId <- value)
            ({ assignments = state.assignments } : CloudhsmV2HsmState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudhsm_v2_hsm#availability_zone-1">CloudhsmV2Hsm#availability_zone</a>.
        /// </summary>
        [<CustomOperation "availability_zone">]
        member _.AvailabilityZone(state: CloudhsmV2HsmState<'ClusterId>, value: string) : CloudhsmV2HsmState<'ClusterId> =
            state.assignments.Add(fun config -> config.AvailabilityZone <- value)
            state : CloudhsmV2HsmState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudhsm_v2_hsm#id-1">CloudhsmV2Hsm#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudhsmV2HsmState<'ClusterId>, value: string) : CloudhsmV2HsmState<'ClusterId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudhsmV2HsmState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudhsm_v2_hsm#ip_address-1">CloudhsmV2Hsm#ip_address</a>.
        /// </summary>
        [<CustomOperation "ip_address">]
        member _.IpAddress(state: CloudhsmV2HsmState<'ClusterId>, value: string) : CloudhsmV2HsmState<'ClusterId> =
            state.assignments.Add(fun config -> config.IpAddress <- value)
            state : CloudhsmV2HsmState<'ClusterId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudhsm_v2_hsm#subnet_id-1">CloudhsmV2Hsm#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: CloudhsmV2HsmState<'ClusterId>, value: string) : CloudhsmV2HsmState<'ClusterId> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            state : CloudhsmV2HsmState<'ClusterId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudhsm_v2_hsm#timeouts-1">CloudhsmV2Hsm#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CloudhsmV2HsmState<'ClusterId>, value: aws.CloudhsmV2Hsm.CloudhsmV2HsmTimeouts) : CloudhsmV2HsmState<'ClusterId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CloudhsmV2HsmState<'ClusterId>

        member _.Run(state: CloudhsmV2HsmState<Present>) : aws.CloudhsmV2Hsm.CloudhsmV2Hsm =
            let config = aws.CloudhsmV2Hsm.CloudhsmV2HsmConfig()
            for setter in state.assignments do
                setter config
            aws.CloudhsmV2Hsm.CloudhsmV2Hsm(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudhsmV2Hsm: missing required arguments. Must call: cluster_id.", 9999, IsError = true)>]
        member _.Run(_: CloudhsmV2HsmState<_>) : aws.CloudhsmV2Hsm.CloudhsmV2Hsm =
            Unchecked.defaultof<aws.CloudhsmV2Hsm.CloudhsmV2Hsm>
