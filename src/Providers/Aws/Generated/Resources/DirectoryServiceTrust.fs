namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DirectoryServiceTrustState<'DirectoryId, 'RemoteDomainName, 'TrustDirection, 'TrustPassword> = { assignments: ResizeArray<aws.DirectoryServiceTrust.DirectoryServiceTrustConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_trust">aws_directory_service_trust</a>.
    /// </summary>
    type DirectoryServiceTrustBuilder(logicalId: string) =
        member _.Yield(_: unit) : DirectoryServiceTrustState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DirectoryServiceTrustState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DirectoryServiceTrustState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DirectoryServiceTrustState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_trust#directory_id-1">DirectoryServiceTrust#directory_id</a>.
        /// </summary>
        [<CustomOperation "directory_id">]
        member _.DirectoryId(state: DirectoryServiceTrustState<Missing, 'RemoteDomainName, 'TrustDirection, 'TrustPassword>, value: string) : DirectoryServiceTrustState<Present, 'RemoteDomainName, 'TrustDirection, 'TrustPassword> =
            state.assignments.Add(fun config -> config.DirectoryId <- value)
            ({ assignments = state.assignments } : DirectoryServiceTrustState<Present, 'RemoteDomainName, 'TrustDirection, 'TrustPassword>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_trust#remote_domain_name-1">DirectoryServiceTrust#remote_domain_name</a>.
        /// </summary>
        [<CustomOperation "remote_domain_name">]
        member _.RemoteDomainName(state: DirectoryServiceTrustState<'DirectoryId, Missing, 'TrustDirection, 'TrustPassword>, value: string) : DirectoryServiceTrustState<'DirectoryId, Present, 'TrustDirection, 'TrustPassword> =
            state.assignments.Add(fun config -> config.RemoteDomainName <- value)
            ({ assignments = state.assignments } : DirectoryServiceTrustState<'DirectoryId, Present, 'TrustDirection, 'TrustPassword>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_trust#trust_direction-1">DirectoryServiceTrust#trust_direction</a>.
        /// </summary>
        [<CustomOperation "trust_direction">]
        member _.TrustDirection(state: DirectoryServiceTrustState<'DirectoryId, 'RemoteDomainName, Missing, 'TrustPassword>, value: string) : DirectoryServiceTrustState<'DirectoryId, 'RemoteDomainName, Present, 'TrustPassword> =
            state.assignments.Add(fun config -> config.TrustDirection <- value)
            ({ assignments = state.assignments } : DirectoryServiceTrustState<'DirectoryId, 'RemoteDomainName, Present, 'TrustPassword>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_trust#trust_password-1">DirectoryServiceTrust#trust_password</a>.
        /// </summary>
        [<CustomOperation "trust_password">]
        member _.TrustPassword(state: DirectoryServiceTrustState<'DirectoryId, 'RemoteDomainName, 'TrustDirection, Missing>, value: string) : DirectoryServiceTrustState<'DirectoryId, 'RemoteDomainName, 'TrustDirection, Present> =
            state.assignments.Add(fun config -> config.TrustPassword <- value)
            ({ assignments = state.assignments } : DirectoryServiceTrustState<'DirectoryId, 'RemoteDomainName, 'TrustDirection, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_trust#conditional_forwarder_ip_addrs-1">DirectoryServiceTrust#conditional_forwarder_ip_addrs</a>.
        /// </summary>
        [<CustomOperation "conditional_forwarder_ip_addrs">]
        member _.ConditionalForwarderIpAddrs(state: DirectoryServiceTrustState<'DirectoryId, 'RemoteDomainName, 'TrustDirection, 'TrustPassword>, value: seq<string>) : DirectoryServiceTrustState<'DirectoryId, 'RemoteDomainName, 'TrustDirection, 'TrustPassword> =
            state.assignments.Add(fun config -> config.ConditionalForwarderIpAddrs <- (value |> Seq.toArray))
            state : DirectoryServiceTrustState<'DirectoryId, 'RemoteDomainName, 'TrustDirection, 'TrustPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_trust#delete_associated_conditional_forwarder-1">DirectoryServiceTrust#delete_associated_conditional_forwarder</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "delete_associated_conditional_forwarder">]
        member _.DeleteAssociatedConditionalForwarder(state: DirectoryServiceTrustState<'DirectoryId, 'RemoteDomainName, 'TrustDirection, 'TrustPassword>, value: bool) : DirectoryServiceTrustState<'DirectoryId, 'RemoteDomainName, 'TrustDirection, 'TrustPassword> =
            state.assignments.Add(fun config -> config.DeleteAssociatedConditionalForwarder <- value)
            state : DirectoryServiceTrustState<'DirectoryId, 'RemoteDomainName, 'TrustDirection, 'TrustPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_trust#delete_associated_conditional_forwarder-1">DirectoryServiceTrust#delete_associated_conditional_forwarder</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "delete_associated_conditional_forwarder">]
        member _.DeleteAssociatedConditionalForwarder(state: DirectoryServiceTrustState<'DirectoryId, 'RemoteDomainName, 'TrustDirection, 'TrustPassword>, value: HashiCorp.Cdktf.IResolvable) : DirectoryServiceTrustState<'DirectoryId, 'RemoteDomainName, 'TrustDirection, 'TrustPassword> =
            state.assignments.Add(fun config -> config.DeleteAssociatedConditionalForwarder <- value)
            state : DirectoryServiceTrustState<'DirectoryId, 'RemoteDomainName, 'TrustDirection, 'TrustPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_trust#selective_auth-1">DirectoryServiceTrust#selective_auth</a>.
        /// </summary>
        [<CustomOperation "selective_auth">]
        member _.SelectiveAuth(state: DirectoryServiceTrustState<'DirectoryId, 'RemoteDomainName, 'TrustDirection, 'TrustPassword>, value: string) : DirectoryServiceTrustState<'DirectoryId, 'RemoteDomainName, 'TrustDirection, 'TrustPassword> =
            state.assignments.Add(fun config -> config.SelectiveAuth <- value)
            state : DirectoryServiceTrustState<'DirectoryId, 'RemoteDomainName, 'TrustDirection, 'TrustPassword>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_trust#trust_type-1">DirectoryServiceTrust#trust_type</a>.
        /// </summary>
        [<CustomOperation "trust_type">]
        member _.TrustType(state: DirectoryServiceTrustState<'DirectoryId, 'RemoteDomainName, 'TrustDirection, 'TrustPassword>, value: string) : DirectoryServiceTrustState<'DirectoryId, 'RemoteDomainName, 'TrustDirection, 'TrustPassword> =
            state.assignments.Add(fun config -> config.TrustType <- value)
            state : DirectoryServiceTrustState<'DirectoryId, 'RemoteDomainName, 'TrustDirection, 'TrustPassword>

        member _.Run(state: DirectoryServiceTrustState<Present, Present, Present, Present>) : aws.DirectoryServiceTrust.DirectoryServiceTrust =
            let config = aws.DirectoryServiceTrust.DirectoryServiceTrustConfig()
            for setter in state.assignments do
                setter config
            aws.DirectoryServiceTrust.DirectoryServiceTrust(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.directoryServiceTrust: missing required arguments. Must call: directory_id, remote_domain_name, trust_direction, trust_password.", 9999, IsError = true)>]
        member _.Run(_: DirectoryServiceTrustState<_, _, _, _>) : aws.DirectoryServiceTrust.DirectoryServiceTrust =
            Unchecked.defaultof<aws.DirectoryServiceTrust.DirectoryServiceTrust>
