﻿namespace Midity
{
    public sealed class NoteEventPair
    {
        public uint LengthTick { get; internal set; }
        public readonly OnNoteEvent onNoteEvent;
        public readonly OffNoteEvent offNoteEvent;

        internal NoteEventPair(OnNoteEvent onNoteEvent, OffNoteEvent offNoteEvent, uint lengthTick)
        {
            this.onNoteEvent = onNoteEvent;
            this.offNoteEvent = offNoteEvent;
            LengthTick = lengthTick;
        }

        public byte Channel
        {
            get => onNoteEvent.Channel;
            set => onNoteEvent.Channel = offNoteEvent.Channel = value;
        }

        public byte NoteNumber
        {
            get => onNoteEvent.NoteNumber;
            set => onNoteEvent.NoteNumber = offNoteEvent.NoteNumber = value;
        }

        public NoteName NoteName
        {
            get => onNoteEvent.NoteName;
            set => onNoteEvent.NoteName = offNoteEvent.NoteName = value;
        }

        public NoteOctave NoteOctave
        {
            get => onNoteEvent.NoteOctave;
            set => onNoteEvent.NoteOctave = offNoteEvent.NoteOctave = value;
        }

        public byte Velocity
        {
            get => onNoteEvent.Velocity;
            set => onNoteEvent.Velocity = value;
        }
    }
}