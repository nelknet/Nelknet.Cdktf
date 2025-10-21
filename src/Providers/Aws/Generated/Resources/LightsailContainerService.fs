namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LightsailContainerServiceState<'Name, 'Power, 'Scale> = { assignments: ResizeArray<aws.LightsailContainerService.LightsailContainerServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service">aws_lightsail_container_service</a>.
    /// </summary>
    type LightsailContainerServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : LightsailContainerServiceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailContainerServiceState<Missing, Missing, Missing>)

        member _.Zero(()) : LightsailContainerServiceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailContainerServiceState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service#name-1">LightsailContainerService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LightsailContainerServiceState<Missing, 'Power, 'Scale>, value: string) : LightsailContainerServiceState<Present, 'Power, 'Scale> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LightsailContainerServiceState<Present, 'Power, 'Scale>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service#power-1">LightsailContainerService#power</a>.
        /// </summary>
        [<CustomOperation "power">]
        member _.Power(state: LightsailContainerServiceState<'Name, Missing, 'Scale>, value: string) : LightsailContainerServiceState<'Name, Present, 'Scale> =
            state.assignments.Add(fun config -> config.Power <- value)
            ({ assignments = state.assignments } : LightsailContainerServiceState<'Name, Present, 'Scale>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service#scale-1">LightsailContainerService#scale</a>.
        /// </summary>
        [<CustomOperation "scale">]
        member _.Scale(state: LightsailContainerServiceState<'Name, 'Power, Missing>, value: double) : LightsailContainerServiceState<'Name, 'Power, Present> =
            state.assignments.Add(fun config -> config.Scale <- value)
            ({ assignments = state.assignments } : LightsailContainerServiceState<'Name, 'Power, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service#id-1">LightsailContainerService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LightsailContainerServiceState<'Name, 'Power, 'Scale>, value: string) : LightsailContainerServiceState<'Name, 'Power, 'Scale> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LightsailContainerServiceState<'Name, 'Power, 'Scale>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service#is_disabled-1">LightsailContainerService#is_disabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "is_disabled">]
        member _.IsDisabled(state: LightsailContainerServiceState<'Name, 'Power, 'Scale>, value: bool) : LightsailContainerServiceState<'Name, 'Power, 'Scale> =
            state.assignments.Add(fun config -> config.IsDisabled <- value)
            state : LightsailContainerServiceState<'Name, 'Power, 'Scale>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service#is_disabled-1">LightsailContainerService#is_disabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "is_disabled">]
        member _.IsDisabled(state: LightsailContainerServiceState<'Name, 'Power, 'Scale>, value: HashiCorp.Cdktf.IResolvable) : LightsailContainerServiceState<'Name, 'Power, 'Scale> =
            state.assignments.Add(fun config -> config.IsDisabled <- value)
            state : LightsailContainerServiceState<'Name, 'Power, 'Scale>

        /// <summary>
        /// private_registry_access block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service#private_registry_access-1">LightsailContainerService#private_registry_access</a>
        /// </summary>
        [<CustomOperation "private_registry_access">]
        member _.PrivateRegistryAccess(state: LightsailContainerServiceState<'Name, 'Power, 'Scale>, value: aws.LightsailContainerService.LightsailContainerServicePrivateRegistryAccess) : LightsailContainerServiceState<'Name, 'Power, 'Scale> =
            state.assignments.Add(fun config -> config.PrivateRegistryAccess <- value)
            state : LightsailContainerServiceState<'Name, 'Power, 'Scale>

        /// <summary>
        /// public_domain_names block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service#public_domain_names-1">LightsailContainerService#public_domain_names</a>
        /// </summary>
        [<CustomOperation "public_domain_names">]
        member _.PublicDomainNames(state: LightsailContainerServiceState<'Name, 'Power, 'Scale>, value: aws.LightsailContainerService.LightsailContainerServicePublicDomainNames) : LightsailContainerServiceState<'Name, 'Power, 'Scale> =
            state.assignments.Add(fun config -> config.PublicDomainNames <- value)
            state : LightsailContainerServiceState<'Name, 'Power, 'Scale>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service#tags-1">LightsailContainerService#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LightsailContainerServiceState<'Name, 'Power, 'Scale>, value: seq<string * string>) : LightsailContainerServiceState<'Name, 'Power, 'Scale> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LightsailContainerServiceState<'Name, 'Power, 'Scale>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service#tags_all-1">LightsailContainerService#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: LightsailContainerServiceState<'Name, 'Power, 'Scale>, value: seq<string * string>) : LightsailContainerServiceState<'Name, 'Power, 'Scale> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : LightsailContainerServiceState<'Name, 'Power, 'Scale>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_container_service#timeouts-1">LightsailContainerService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LightsailContainerServiceState<'Name, 'Power, 'Scale>, value: aws.LightsailContainerService.LightsailContainerServiceTimeouts) : LightsailContainerServiceState<'Name, 'Power, 'Scale> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LightsailContainerServiceState<'Name, 'Power, 'Scale>

        member _.Run(state: LightsailContainerServiceState<Present, Present, Present>) : aws.LightsailContainerService.LightsailContainerService =
            let config = aws.LightsailContainerService.LightsailContainerServiceConfig()
            for setter in state.assignments do
                setter config
            aws.LightsailContainerService.LightsailContainerService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lightsailContainerService: missing required arguments. Must call: name, power, scale.", 9999, IsError = true)>]
        member _.Run(_: LightsailContainerServiceState<_, _, _>) : aws.LightsailContainerService.LightsailContainerService =
            Unchecked.defaultof<aws.LightsailContainerService.LightsailContainerService>
