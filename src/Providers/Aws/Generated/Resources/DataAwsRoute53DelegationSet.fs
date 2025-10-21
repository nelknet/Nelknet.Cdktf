namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRoute53DelegationSetState<'Id> = { assignments: ResizeArray<aws.DataAwsRoute53DelegationSet.DataAwsRoute53DelegationSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_delegation_set">aws_route53_delegation_set</a>.
    /// </summary>
    type DataAwsRoute53DelegationSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRoute53DelegationSetState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRoute53DelegationSetState<Missing>)

        member _.Zero(()) : DataAwsRoute53DelegationSetState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRoute53DelegationSetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_delegation_set#id-1">DataAwsRoute53DelegationSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRoute53DelegationSetState<Missing>, value: string) : DataAwsRoute53DelegationSetState<Present> =
            state.assignments.Add(fun config -> config.Id <- value)
            ({ assignments = state.assignments } : DataAwsRoute53DelegationSetState<Present>)

        member _.Run(state: DataAwsRoute53DelegationSetState<Present>) : aws.DataAwsRoute53DelegationSet.DataAwsRoute53DelegationSet =
            let config = aws.DataAwsRoute53DelegationSet.DataAwsRoute53DelegationSetConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRoute53DelegationSet.DataAwsRoute53DelegationSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsRoute53DelegationSet: missing required arguments. Must call: id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsRoute53DelegationSetState<_>) : aws.DataAwsRoute53DelegationSet.DataAwsRoute53DelegationSet =
            Unchecked.defaultof<aws.DataAwsRoute53DelegationSet.DataAwsRoute53DelegationSet>
