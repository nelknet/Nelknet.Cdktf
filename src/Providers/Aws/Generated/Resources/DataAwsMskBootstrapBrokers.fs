namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsMskBootstrapBrokersState<'ClusterArn> = { assignments: ResizeArray<aws.DataAwsMskBootstrapBrokers.DataAwsMskBootstrapBrokersConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/msk_bootstrap_brokers">aws_msk_bootstrap_brokers</a>.
    /// </summary>
    type DataAwsMskBootstrapBrokersBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsMskBootstrapBrokersState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMskBootstrapBrokersState<Missing>)

        member _.Zero(()) : DataAwsMskBootstrapBrokersState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsMskBootstrapBrokersState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/msk_bootstrap_brokers#cluster_arn-1">DataAwsMskBootstrapBrokers#cluster_arn</a>.
        /// </summary>
        [<CustomOperation "cluster_arn">]
        member _.ClusterArn(state: DataAwsMskBootstrapBrokersState<Missing>, value: string) : DataAwsMskBootstrapBrokersState<Present> =
            state.assignments.Add(fun config -> config.ClusterArn <- value)
            ({ assignments = state.assignments } : DataAwsMskBootstrapBrokersState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/msk_bootstrap_brokers#id-1">DataAwsMskBootstrapBrokers#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsMskBootstrapBrokersState<'ClusterArn>, value: string) : DataAwsMskBootstrapBrokersState<'ClusterArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsMskBootstrapBrokersState<'ClusterArn>

        member _.Run(state: DataAwsMskBootstrapBrokersState<Present>) : aws.DataAwsMskBootstrapBrokers.DataAwsMskBootstrapBrokers =
            let config = aws.DataAwsMskBootstrapBrokers.DataAwsMskBootstrapBrokersConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsMskBootstrapBrokers.DataAwsMskBootstrapBrokers(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsMskBootstrapBrokers: missing required arguments. Must call: cluster_arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsMskBootstrapBrokersState<_>) : aws.DataAwsMskBootstrapBrokers.DataAwsMskBootstrapBrokers =
            Unchecked.defaultof<aws.DataAwsMskBootstrapBrokers.DataAwsMskBootstrapBrokers>
