namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DirectoryServiceConditionalForwarderState<'DirectoryId, 'DnsIps, 'RemoteDomainName> = { assignments: ResizeArray<aws.DirectoryServiceConditionalForwarder.DirectoryServiceConditionalForwarderConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_conditional_forwarder">aws_directory_service_conditional_forwarder</a>.
    /// </summary>
    type DirectoryServiceConditionalForwarderBuilder(logicalId: string) =
        member _.Yield(_: unit) : DirectoryServiceConditionalForwarderState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DirectoryServiceConditionalForwarderState<Missing, Missing, Missing>)

        member _.Zero(()) : DirectoryServiceConditionalForwarderState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DirectoryServiceConditionalForwarderState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_conditional_forwarder#directory_id-1">DirectoryServiceConditionalForwarder#directory_id</a>.
        /// </summary>
        [<CustomOperation "directory_id">]
        member _.DirectoryId(state: DirectoryServiceConditionalForwarderState<Missing, 'DnsIps, 'RemoteDomainName>, value: string) : DirectoryServiceConditionalForwarderState<Present, 'DnsIps, 'RemoteDomainName> =
            state.assignments.Add(fun config -> config.DirectoryId <- value)
            ({ assignments = state.assignments } : DirectoryServiceConditionalForwarderState<Present, 'DnsIps, 'RemoteDomainName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_conditional_forwarder#dns_ips-1">DirectoryServiceConditionalForwarder#dns_ips</a>.
        /// </summary>
        [<CustomOperation "dns_ips">]
        member _.DnsIps(state: DirectoryServiceConditionalForwarderState<'DirectoryId, Missing, 'RemoteDomainName>, value: seq<string>) : DirectoryServiceConditionalForwarderState<'DirectoryId, Present, 'RemoteDomainName> =
            state.assignments.Add(fun config -> config.DnsIps <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DirectoryServiceConditionalForwarderState<'DirectoryId, Present, 'RemoteDomainName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_conditional_forwarder#remote_domain_name-1">DirectoryServiceConditionalForwarder#remote_domain_name</a>.
        /// </summary>
        [<CustomOperation "remote_domain_name">]
        member _.RemoteDomainName(state: DirectoryServiceConditionalForwarderState<'DirectoryId, 'DnsIps, Missing>, value: string) : DirectoryServiceConditionalForwarderState<'DirectoryId, 'DnsIps, Present> =
            state.assignments.Add(fun config -> config.RemoteDomainName <- value)
            ({ assignments = state.assignments } : DirectoryServiceConditionalForwarderState<'DirectoryId, 'DnsIps, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_conditional_forwarder#id-1">DirectoryServiceConditionalForwarder#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DirectoryServiceConditionalForwarderState<'DirectoryId, 'DnsIps, 'RemoteDomainName>, value: string) : DirectoryServiceConditionalForwarderState<'DirectoryId, 'DnsIps, 'RemoteDomainName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DirectoryServiceConditionalForwarderState<'DirectoryId, 'DnsIps, 'RemoteDomainName>

        member _.Run(state: DirectoryServiceConditionalForwarderState<Present, Present, Present>) : aws.DirectoryServiceConditionalForwarder.DirectoryServiceConditionalForwarder =
            let config = aws.DirectoryServiceConditionalForwarder.DirectoryServiceConditionalForwarderConfig()
            for setter in state.assignments do
                setter config
            aws.DirectoryServiceConditionalForwarder.DirectoryServiceConditionalForwarder(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.directoryServiceConditionalForwarder: missing required arguments. Must call: directory_id, dns_ips, remote_domain_name.", 9999, IsError = true)>]
        member _.Run(_: DirectoryServiceConditionalForwarderState<_, _, _>) : aws.DirectoryServiceConditionalForwarder.DirectoryServiceConditionalForwarder =
            Unchecked.defaultof<aws.DirectoryServiceConditionalForwarder.DirectoryServiceConditionalForwarder>
