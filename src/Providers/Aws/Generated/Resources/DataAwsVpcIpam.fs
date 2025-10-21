namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsVpcIpamState<'Id> = { assignments: ResizeArray<aws.DataAwsVpcIpam.DataAwsVpcIpamConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_ipam">aws_vpc_ipam</a>.
    /// </summary>
    type DataAwsVpcIpamBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsVpcIpamState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsVpcIpamState<Missing>)

        member _.Zero(()) : DataAwsVpcIpamState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsVpcIpamState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_ipam#id-1">DataAwsVpcIpam#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsVpcIpamState<Missing>, value: string) : DataAwsVpcIpamState<Present> =
            state.assignments.Add(fun config -> config.Id <- value)
            ({ assignments = state.assignments } : DataAwsVpcIpamState<Present>)

        member _.Run(state: DataAwsVpcIpamState<Present>) : aws.DataAwsVpcIpam.DataAwsVpcIpam =
            let config = aws.DataAwsVpcIpam.DataAwsVpcIpamConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsVpcIpam.DataAwsVpcIpam(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsVpcIpam: missing required arguments. Must call: id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsVpcIpamState<_>) : aws.DataAwsVpcIpam.DataAwsVpcIpam =
            Unchecked.defaultof<aws.DataAwsVpcIpam.DataAwsVpcIpam>
