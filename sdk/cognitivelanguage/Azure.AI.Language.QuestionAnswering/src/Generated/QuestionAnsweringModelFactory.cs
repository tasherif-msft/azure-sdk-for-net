// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Language.QuestionAnswering
{
    /// <summary> Model factory for models. </summary>
    public static partial class QuestionAnsweringModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="QuestionAnswering.AnswersResult"/>. </summary>
        /// <param name="answers"> Represents Answer Result list. </param>
        /// <returns> A new <see cref="QuestionAnswering.AnswersResult"/> instance for mocking. </returns>
        public static AnswersResult AnswersResult(IEnumerable<KnowledgeBaseAnswer> answers = null)
        {
            answers ??= new List<KnowledgeBaseAnswer>();

            return new AnswersResult(answers?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="QuestionAnswering.KnowledgeBaseAnswer"/>. </summary>
        /// <param name="questions"> List of questions associated with the answer. </param>
        /// <param name="answer"> Answer text. </param>
        /// <param name="confidence"> Answer confidence score, value ranges from 0 to 1. </param>
        /// <param name="qnaId"> ID of the QnA result. </param>
        /// <param name="source"> Source of QnA result. </param>
        /// <param name="metadata"> Metadata associated with the answer, useful to categorize or filter question answers. </param>
        /// <param name="dialog"> Dialog associated with Answer. </param>
        /// <param name="shortAnswer"> Answer span object of QnA with respect to user's question. </param>
        /// <returns> A new <see cref="QuestionAnswering.KnowledgeBaseAnswer"/> instance for mocking. </returns>
        public static KnowledgeBaseAnswer KnowledgeBaseAnswer(IEnumerable<string> questions = null, string answer = null, double? confidence = null, int? qnaId = null, string source = null, IReadOnlyDictionary<string, string> metadata = null, KnowledgeBaseAnswerDialog dialog = null, AnswerSpan shortAnswer = null)
        {
            questions ??= new List<string>();
            metadata ??= new Dictionary<string, string>();

            return new KnowledgeBaseAnswer(
                questions?.ToList(),
                answer,
                confidence,
                qnaId,
                source,
                metadata,
                dialog,
                shortAnswer);
        }

        /// <summary> Initializes a new instance of <see cref="QuestionAnswering.KnowledgeBaseAnswerDialog"/>. </summary>
        /// <param name="isContextOnly"> To mark if a prompt is relevant only with a previous question or not. If true, do not include this QnA as search result for queries without context; otherwise, if false, ignores context and includes this QnA in search result. </param>
        /// <param name="prompts"> List of prompts associated with the answer. </param>
        /// <returns> A new <see cref="QuestionAnswering.KnowledgeBaseAnswerDialog"/> instance for mocking. </returns>
        public static KnowledgeBaseAnswerDialog KnowledgeBaseAnswerDialog(bool? isContextOnly = null, IEnumerable<KnowledgeBaseAnswerPrompt> prompts = null)
        {
            prompts ??= new List<KnowledgeBaseAnswerPrompt>();

            return new KnowledgeBaseAnswerDialog(isContextOnly, prompts?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="QuestionAnswering.KnowledgeBaseAnswerPrompt"/>. </summary>
        /// <param name="displayOrder"> Index of the prompt - used in ordering of the prompts. </param>
        /// <param name="qnaId"> QnA ID corresponding to the prompt. </param>
        /// <param name="displayText"> Text displayed to represent a follow up question prompt. </param>
        /// <returns> A new <see cref="QuestionAnswering.KnowledgeBaseAnswerPrompt"/> instance for mocking. </returns>
        public static KnowledgeBaseAnswerPrompt KnowledgeBaseAnswerPrompt(int? displayOrder = null, int? qnaId = null, string displayText = null)
        {
            return new KnowledgeBaseAnswerPrompt(displayOrder, qnaId, displayText);
        }

        /// <summary> Initializes a new instance of <see cref="QuestionAnswering.AnswerSpan"/>. </summary>
        /// <param name="text"> Predicted text of answer span. </param>
        /// <param name="confidence"> Predicted score of answer span, value ranges from 0 to 1. </param>
        /// <param name="offset"> The answer span offset from the start of answer. </param>
        /// <param name="length"> The length of the answer span. </param>
        /// <returns> A new <see cref="QuestionAnswering.AnswerSpan"/> instance for mocking. </returns>
        public static AnswerSpan AnswerSpan(string text = null, double? confidence = null, int? offset = null, int? length = null)
        {
            return new AnswerSpan(text, confidence, offset, length);
        }

        /// <summary> Initializes a new instance of <see cref="QuestionAnswering.AnswersFromTextResult"/>. </summary>
        /// <param name="answers"> Represents the answer results. </param>
        /// <returns> A new <see cref="QuestionAnswering.AnswersFromTextResult"/> instance for mocking. </returns>
        public static AnswersFromTextResult AnswersFromTextResult(IEnumerable<TextAnswer> answers = null)
        {
            answers ??= new List<TextAnswer>();

            return new AnswersFromTextResult(answers?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="QuestionAnswering.TextAnswer"/>. </summary>
        /// <param name="answer"> Answer. </param>
        /// <param name="confidence"> answer confidence score, value ranges from 0 to 1. </param>
        /// <param name="id"> record ID. </param>
        /// <param name="shortAnswer"> Answer span object with respect to user's question. </param>
        /// <param name="offset"> The sentence offset from the start of the document. </param>
        /// <param name="length"> The length of the sentence. </param>
        /// <returns> A new <see cref="QuestionAnswering.TextAnswer"/> instance for mocking. </returns>
        public static TextAnswer TextAnswer(string answer = null, double? confidence = null, string id = null, AnswerSpan shortAnswer = null, int? offset = null, int? length = null)
        {
            return new TextAnswer(
                answer,
                confidence,
                id,
                shortAnswer,
                offset,
                length);
        }
    }
}
