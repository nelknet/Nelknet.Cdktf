namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsDatazoneDomainState = { assignments: ResizeArray<aws.DataAwsDatazoneDomain.DataAwsDatazoneDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/datazone_domain">aws_datazone_domain</a>.
    /// </summary>
    type DataAwsDatazoneDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsDatazoneDomainState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsDatazoneDomainState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/datazone_domain#id-1">DataAwsDatazoneDomain#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsDatazoneDomainState, value: string) : DataAwsDatazoneDomainState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsDatazoneDomainState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/datazone_domain#name-1">DataAwsDatazoneDomain#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsDatazoneDomainState, value: string) : DataAwsDatazoneDomainState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsDatazoneDomainState

        member _.Run(state: DataAwsDatazoneDomainState) : aws.DataAwsDatazoneDomain.DataAwsDatazoneDomain =
            let config = aws.DataAwsDatazoneDomain.DataAwsDatazoneDomainConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsDatazoneDomain.DataAwsDatazoneDomain(StackContext.get (), logicalId, config)
