namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FinspaceKxEnvironmentState<'KmsKeyId, 'Name> = { assignments: ResizeArray<aws.FinspaceKxEnvironment.FinspaceKxEnvironmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment">aws_finspace_kx_environment</a>.
    /// </summary>
    type FinspaceKxEnvironmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : FinspaceKxEnvironmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : FinspaceKxEnvironmentState<Missing, Missing>)

        member _.Zero(()) : FinspaceKxEnvironmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : FinspaceKxEnvironmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#kms_key_id-1">FinspaceKxEnvironment#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: FinspaceKxEnvironmentState<Missing, 'Name>, value: string) : FinspaceKxEnvironmentState<Present, 'Name> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            ({ assignments = state.assignments } : FinspaceKxEnvironmentState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#name-1">FinspaceKxEnvironment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: FinspaceKxEnvironmentState<'KmsKeyId, Missing>, value: string) : FinspaceKxEnvironmentState<'KmsKeyId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : FinspaceKxEnvironmentState<'KmsKeyId, Present>)

        /// <summary>
        /// custom_dns_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#custom_dns_configuration-1">FinspaceKxEnvironment#custom_dns_configuration</a> Accepts: aws.IResolvable | aws.FinspaceKxEnvironment.FinspaceKxEnvironmentCustomDnsConfiguration[]
        /// </summary>
        [<CustomOperation "custom_dns_configuration">]
        member _.CustomDnsConfiguration(state: FinspaceKxEnvironmentState<'KmsKeyId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : FinspaceKxEnvironmentState<'KmsKeyId, 'Name> =
            state.assignments.Add(fun config -> config.CustomDnsConfiguration <- value)
            state : FinspaceKxEnvironmentState<'KmsKeyId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#description-1">FinspaceKxEnvironment#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: FinspaceKxEnvironmentState<'KmsKeyId, 'Name>, value: string) : FinspaceKxEnvironmentState<'KmsKeyId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : FinspaceKxEnvironmentState<'KmsKeyId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#tags-1">FinspaceKxEnvironment#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: FinspaceKxEnvironmentState<'KmsKeyId, 'Name>, value: seq<string * string>) : FinspaceKxEnvironmentState<'KmsKeyId, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : FinspaceKxEnvironmentState<'KmsKeyId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#tags_all-1">FinspaceKxEnvironment#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: FinspaceKxEnvironmentState<'KmsKeyId, 'Name>, value: seq<string * string>) : FinspaceKxEnvironmentState<'KmsKeyId, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : FinspaceKxEnvironmentState<'KmsKeyId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#timeouts-1">FinspaceKxEnvironment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FinspaceKxEnvironmentState<'KmsKeyId, 'Name>, value: aws.FinspaceKxEnvironment.FinspaceKxEnvironmentTimeouts) : FinspaceKxEnvironmentState<'KmsKeyId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FinspaceKxEnvironmentState<'KmsKeyId, 'Name>

        /// <summary>
        /// transit_gateway_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_environment#transit_gateway_configuration-1">FinspaceKxEnvironment#transit_gateway_configuration</a>
        /// </summary>
        [<CustomOperation "transit_gateway_configuration">]
        member _.TransitGatewayConfiguration(state: FinspaceKxEnvironmentState<'KmsKeyId, 'Name>, value: aws.FinspaceKxEnvironment.FinspaceKxEnvironmentTransitGatewayConfiguration) : FinspaceKxEnvironmentState<'KmsKeyId, 'Name> =
            state.assignments.Add(fun config -> config.TransitGatewayConfiguration <- value)
            state : FinspaceKxEnvironmentState<'KmsKeyId, 'Name>

        member _.Run(state: FinspaceKxEnvironmentState<Present, Present>) : aws.FinspaceKxEnvironment.FinspaceKxEnvironment =
            let config = aws.FinspaceKxEnvironment.FinspaceKxEnvironmentConfig()
            for setter in state.assignments do
                setter config
            aws.FinspaceKxEnvironment.FinspaceKxEnvironment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.finspaceKxEnvironment: missing required arguments. Must call: kms_key_id, name.", 9999, IsError = true)>]
        member _.Run(_: FinspaceKxEnvironmentState<_, _>) : aws.FinspaceKxEnvironment.FinspaceKxEnvironment =
            Unchecked.defaultof<aws.FinspaceKxEnvironment.FinspaceKxEnvironment>
