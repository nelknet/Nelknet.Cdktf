namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LightsailDomainEntryState<'DomainName, 'Name, 'Target, 'Type> = { assignments: ResizeArray<aws.LightsailDomainEntry.LightsailDomainEntryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_domain_entry">aws_lightsail_domain_entry</a>.
    /// </summary>
    type LightsailDomainEntryBuilder(logicalId: string) =
        member _.Yield(_: unit) : LightsailDomainEntryState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailDomainEntryState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LightsailDomainEntryState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailDomainEntryState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_domain_entry#domain_name-1">LightsailDomainEntry#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: LightsailDomainEntryState<Missing, 'Name, 'Target, 'Type>, value: string) : LightsailDomainEntryState<Present, 'Name, 'Target, 'Type> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : LightsailDomainEntryState<Present, 'Name, 'Target, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_domain_entry#name-1">LightsailDomainEntry#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LightsailDomainEntryState<'DomainName, Missing, 'Target, 'Type>, value: string) : LightsailDomainEntryState<'DomainName, Present, 'Target, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LightsailDomainEntryState<'DomainName, Present, 'Target, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_domain_entry#target-1">LightsailDomainEntry#target</a>.
        /// </summary>
        [<CustomOperation "target">]
        member _.Target(state: LightsailDomainEntryState<'DomainName, 'Name, Missing, 'Type>, value: string) : LightsailDomainEntryState<'DomainName, 'Name, Present, 'Type> =
            state.assignments.Add(fun config -> config.Target <- value)
            ({ assignments = state.assignments } : LightsailDomainEntryState<'DomainName, 'Name, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_domain_entry#type-1">LightsailDomainEntry#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: LightsailDomainEntryState<'DomainName, 'Name, 'Target, Missing>, value: string) : LightsailDomainEntryState<'DomainName, 'Name, 'Target, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : LightsailDomainEntryState<'DomainName, 'Name, 'Target, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_domain_entry#id-1">LightsailDomainEntry#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LightsailDomainEntryState<'DomainName, 'Name, 'Target, 'Type>, value: string) : LightsailDomainEntryState<'DomainName, 'Name, 'Target, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LightsailDomainEntryState<'DomainName, 'Name, 'Target, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_domain_entry#is_alias-1">LightsailDomainEntry#is_alias</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "is_alias">]
        member _.IsAlias(state: LightsailDomainEntryState<'DomainName, 'Name, 'Target, 'Type>, value: bool) : LightsailDomainEntryState<'DomainName, 'Name, 'Target, 'Type> =
            state.assignments.Add(fun config -> config.IsAlias <- value)
            state : LightsailDomainEntryState<'DomainName, 'Name, 'Target, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_domain_entry#is_alias-1">LightsailDomainEntry#is_alias</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "is_alias">]
        member _.IsAlias(state: LightsailDomainEntryState<'DomainName, 'Name, 'Target, 'Type>, value: HashiCorp.Cdktf.IResolvable) : LightsailDomainEntryState<'DomainName, 'Name, 'Target, 'Type> =
            state.assignments.Add(fun config -> config.IsAlias <- value)
            state : LightsailDomainEntryState<'DomainName, 'Name, 'Target, 'Type>

        member _.Run(state: LightsailDomainEntryState<Present, Present, Present, Present>) : aws.LightsailDomainEntry.LightsailDomainEntry =
            let config = aws.LightsailDomainEntry.LightsailDomainEntryConfig()
            for setter in state.assignments do
                setter config
            aws.LightsailDomainEntry.LightsailDomainEntry(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lightsailDomainEntry: missing required arguments. Must call: domain_name, name, target, type.", 9999, IsError = true)>]
        member _.Run(_: LightsailDomainEntryState<_, _, _, _>) : aws.LightsailDomainEntry.LightsailDomainEntry =
            Unchecked.defaultof<aws.LightsailDomainEntry.LightsailDomainEntry>
