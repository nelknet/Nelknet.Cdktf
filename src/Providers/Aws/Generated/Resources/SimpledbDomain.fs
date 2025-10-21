namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SimpledbDomainState<'Name> = { assignments: ResizeArray<aws.SimpledbDomain.SimpledbDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/simpledb_domain">aws_simpledb_domain</a>.
    /// </summary>
    type SimpledbDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : SimpledbDomainState<Missing> =
            ({ assignments = ResizeArray() } : SimpledbDomainState<Missing>)

        member _.Zero(()) : SimpledbDomainState<Missing> =
            ({ assignments = ResizeArray() } : SimpledbDomainState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/simpledb_domain#name-1">SimpledbDomain#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SimpledbDomainState<Missing>, value: string) : SimpledbDomainState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SimpledbDomainState<Present>)

        member _.Run(state: SimpledbDomainState<Present>) : aws.SimpledbDomain.SimpledbDomain =
            let config = aws.SimpledbDomain.SimpledbDomainConfig()
            for setter in state.assignments do
                setter config
            aws.SimpledbDomain.SimpledbDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.simpledbDomain: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: SimpledbDomainState<_>) : aws.SimpledbDomain.SimpledbDomain =
            Unchecked.defaultof<aws.SimpledbDomain.SimpledbDomain>
