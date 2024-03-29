﻿using System;
using System.Collections.Generic;

namespace Solver2.Graph
{
    public abstract class ANode<TMove>
    {

        #region Abstract
        public abstract double Heuristics(ANode<TMove> final);
        public abstract bool SameAs(ANode<TMove> mate);
        public abstract String Hash { get; }
        #endregion

        #region Genealogy
        private ANode<TMove> _parent;
        public ANode<TMove> Parent
        {
            get { return this._parent; }
            protected set
            {
                if (value != null && this._parent != null)
                    this._parent.Children.Remove(this);

                this._parent = value;

                if (value != null)
                    this._parent.Children.Add(this);
            }
        }
        public List<ANode<TMove>> Children { get; protected set; }
        public TMove MoveFromParent { get; protected set; }
        public void Attach(ANode<TMove> child, TMove moveFromParentToChild)
        {
            child.Parent = this;
            child.MoveFromParent = moveFromParentToChild;
        }
        #endregion

        #region Costs
        public double GCost { get; set; } // coût du chemin du noeud initial jusqu'à ce noeud
        public double HCost { get; set; } // estimation heuristique du coût pour atteindre le noeud final
        public double TotalCost { get { return this.GCost + this.HCost; } }
        #endregion

        #region Overrides
        public override bool Equals(object obj)
        {
            //if (!(obj is ANode<TMove> mate)) return false; // #retro-compatibilité
            if (!(obj is ANode<TMove>)) return false;
            var mate = obj as ANode<TMove>;

            if (Object.ReferenceEquals(this, mate)) return true;
            if (null == this as Object) return null == mate as Object;
            if (null == mate as Object) return null == this as Object;

            if (this.Hash == (mate as ANode<TMove>).Hash) return true;

            return this.SameAs(mate);
        }

        public override int GetHashCode()
        {
            return this.Hash.GetHashCode();
        }

        public override String ToString()
        {
            return this.Hash;
        }
        #endregion

    }
}
