namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLbTrustStoreState = { assignments: ResizeArray<aws.DataAwsLbTrustStore.DataAwsLbTrustStoreConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_trust_store">aws_lb_trust_store</a>.
    /// </summary>
    type DataAwsLbTrustStoreBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLbTrustStoreState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsLbTrustStoreState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_trust_store#arn-1">DataAwsLbTrustStore#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsLbTrustStoreState, value: string) : DataAwsLbTrustStoreState =
            state.assignments.Add(fun config -> config.Arn <- value)
            state : DataAwsLbTrustStoreState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_trust_store#id-1">DataAwsLbTrustStore#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLbTrustStoreState, value: string) : DataAwsLbTrustStoreState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLbTrustStoreState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_trust_store#name-1">DataAwsLbTrustStore#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsLbTrustStoreState, value: string) : DataAwsLbTrustStoreState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsLbTrustStoreState

        member _.Run(state: DataAwsLbTrustStoreState) : aws.DataAwsLbTrustStore.DataAwsLbTrustStore =
            let config = aws.DataAwsLbTrustStore.DataAwsLbTrustStoreConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLbTrustStore.DataAwsLbTrustStore(StackContext.get (), logicalId, config)
