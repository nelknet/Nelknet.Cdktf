namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VerifiedpermissionsSchemaState<'Definition, 'PolicyStoreId> = { assignments: ResizeArray<aws.VerifiedpermissionsSchema.VerifiedpermissionsSchemaConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_schema">aws_verifiedpermissions_schema</a>.
    /// </summary>
    type VerifiedpermissionsSchemaBuilder(logicalId: string) =
        member _.Yield(_: unit) : VerifiedpermissionsSchemaState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VerifiedpermissionsSchemaState<Missing, Missing>)

        member _.Zero(()) : VerifiedpermissionsSchemaState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VerifiedpermissionsSchemaState<Missing, Missing>)

        /// <summary>
        /// definition block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_schema#definition-1">VerifiedpermissionsSchema#definition</a>
        /// </summary>
        [<CustomOperation "definition">]
        member _.Definition(state: VerifiedpermissionsSchemaState<Missing, 'PolicyStoreId>, value: aws.VerifiedpermissionsSchema.VerifiedpermissionsSchemaDefinition) : VerifiedpermissionsSchemaState<Present, 'PolicyStoreId> =
            state.assignments.Add(fun config -> config.Definition <- value)
            ({ assignments = state.assignments } : VerifiedpermissionsSchemaState<Present, 'PolicyStoreId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_schema#policy_store_id-1">VerifiedpermissionsSchema#policy_store_id</a>.
        /// </summary>
        [<CustomOperation "policy_store_id">]
        member _.PolicyStoreId(state: VerifiedpermissionsSchemaState<'Definition, Missing>, value: string) : VerifiedpermissionsSchemaState<'Definition, Present> =
            state.assignments.Add(fun config -> config.PolicyStoreId <- value)
            ({ assignments = state.assignments } : VerifiedpermissionsSchemaState<'Definition, Present>)

        member _.Run(state: VerifiedpermissionsSchemaState<Present, Present>) : aws.VerifiedpermissionsSchema.VerifiedpermissionsSchema =
            let config = aws.VerifiedpermissionsSchema.VerifiedpermissionsSchemaConfig()
            for setter in state.assignments do
                setter config
            aws.VerifiedpermissionsSchema.VerifiedpermissionsSchema(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.verifiedpermissionsSchema: missing required arguments. Must call: definition, policy_store_id.", 9999, IsError = true)>]
        member _.Run(_: VerifiedpermissionsSchemaState<_, _>) : aws.VerifiedpermissionsSchema.VerifiedpermissionsSchema =
            Unchecked.defaultof<aws.VerifiedpermissionsSchema.VerifiedpermissionsSchema>
