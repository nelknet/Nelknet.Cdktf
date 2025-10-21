namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, 'RoleArn> = { assignments: ResizeArray<aws.GlueMlTransform.GlueMlTransformConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform">aws_glue_ml_transform</a>.
    /// </summary>
    type GlueMlTransformBuilder(logicalId: string) =
        member _.Yield(_: unit) : GlueMlTransformState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GlueMlTransformState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : GlueMlTransformState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GlueMlTransformState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// input_record_tables block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#input_record_tables-1">GlueMlTransform#input_record_tables</a> Accepts: aws.IResolvable | aws.GlueMlTransform.GlueMlTransformInputRecordTables[]
        /// </summary>
        [<CustomOperation "input_record_tables">]
        member _.InputRecordTables(state: GlueMlTransformState<Missing, 'Name, 'Parameters, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : GlueMlTransformState<Present, 'Name, 'Parameters, 'RoleArn> =
            state.assignments.Add(fun config -> config.InputRecordTables <- value)
            ({ assignments = state.assignments } : GlueMlTransformState<Present, 'Name, 'Parameters, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#name-1">GlueMlTransform#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GlueMlTransformState<'InputRecordTables, Missing, 'Parameters, 'RoleArn>, value: string) : GlueMlTransformState<'InputRecordTables, Present, 'Parameters, 'RoleArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GlueMlTransformState<'InputRecordTables, Present, 'Parameters, 'RoleArn>)

        /// <summary>
        /// parameters block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#parameters-1">GlueMlTransform#parameters</a>
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: GlueMlTransformState<'InputRecordTables, 'Name, Missing, 'RoleArn>, value: aws.GlueMlTransform.GlueMlTransformParameters) : GlueMlTransformState<'InputRecordTables, 'Name, Present, 'RoleArn> =
            state.assignments.Add(fun config -> config.Parameters <- value)
            ({ assignments = state.assignments } : GlueMlTransformState<'InputRecordTables, 'Name, Present, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#role_arn-1">GlueMlTransform#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, Missing>, value: string) : GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, Present> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#description-1">GlueMlTransform#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, 'RoleArn>, value: string) : GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, 'RoleArn> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#glue_version-1">GlueMlTransform#glue_version</a>.
        /// </summary>
        [<CustomOperation "glue_version">]
        member _.GlueVersion(state: GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, 'RoleArn>, value: string) : GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, 'RoleArn> =
            state.assignments.Add(fun config -> config.GlueVersion <- value)
            state : GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#id-1">GlueMlTransform#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, 'RoleArn>, value: string) : GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, 'RoleArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#max_capacity-1">GlueMlTransform#max_capacity</a>.
        /// </summary>
        [<CustomOperation "max_capacity">]
        member _.MaxCapacity(state: GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, 'RoleArn>, value: double) : GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, 'RoleArn> =
            state.assignments.Add(fun config -> config.MaxCapacity <- value)
            state : GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#max_retries-1">GlueMlTransform#max_retries</a>.
        /// </summary>
        [<CustomOperation "max_retries">]
        member _.MaxRetries(state: GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, 'RoleArn>, value: double) : GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, 'RoleArn> =
            state.assignments.Add(fun config -> config.MaxRetries <- value)
            state : GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#number_of_workers-1">GlueMlTransform#number_of_workers</a>.
        /// </summary>
        [<CustomOperation "number_of_workers">]
        member _.NumberOfWorkers(state: GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, 'RoleArn>, value: double) : GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, 'RoleArn> =
            state.assignments.Add(fun config -> config.NumberOfWorkers <- value)
            state : GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#tags-1">GlueMlTransform#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, 'RoleArn>, value: seq<string * string>) : GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, 'RoleArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#tags_all-1">GlueMlTransform#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, 'RoleArn>, value: seq<string * string>) : GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, 'RoleArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#timeout-1">GlueMlTransform#timeout</a>.
        /// </summary>
        [<CustomOperation "timeout">]
        member _.Timeout(state: GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, 'RoleArn>, value: double) : GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, 'RoleArn> =
            state.assignments.Add(fun config -> config.Timeout <- value)
            state : GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_ml_transform#worker_type-1">GlueMlTransform#worker_type</a>.
        /// </summary>
        [<CustomOperation "worker_type">]
        member _.WorkerType(state: GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, 'RoleArn>, value: string) : GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, 'RoleArn> =
            state.assignments.Add(fun config -> config.WorkerType <- value)
            state : GlueMlTransformState<'InputRecordTables, 'Name, 'Parameters, 'RoleArn>

        member _.Run(state: GlueMlTransformState<Present, Present, Present, Present>) : aws.GlueMlTransform.GlueMlTransform =
            let config = aws.GlueMlTransform.GlueMlTransformConfig()
            for setter in state.assignments do
                setter config
            aws.GlueMlTransform.GlueMlTransform(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.glueMlTransform: missing required arguments. Must call: input_record_tables, name, parameters, role_arn.", 9999, IsError = true)>]
        member _.Run(_: GlueMlTransformState<_, _, _, _>) : aws.GlueMlTransform.GlueMlTransform =
            Unchecked.defaultof<aws.GlueMlTransform.GlueMlTransform>
